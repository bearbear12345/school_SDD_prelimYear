# Read script
with open("story.txt") as f:
  script = [line.strip() for line in f.readlines()]

import re
people = []
for line in script:
  search = re.finditer(r'\[([\w\. ]*)\]\[(\d*)\]', line, flags=re.IGNORECASE)
  for entry in search:
    _name, _id = entry.group(1,2)
    _id = int(_id)
    if not _id in [person[2] for person in people]: people.append([-1,[], _id])
    for person in people:
      if person[2] == _id: person[1].append(_name)

# male or female?
male_pronouns = ["he", "him", "his", "man", "husband", "gentleman", "sir"]
male_identifiers = ["Master", "Mr."]
female_pronouns = ["she", "her", "woman", "wife", "lady", "ma'am"]
female_identifiers = ["Miss", "Mrs.", "Ms."]
for i in range(len(people)):
    people[i-1][0] = 1 if any([True for name in people[i-1][1] if name.split(" ")[0].lower() in [s.lower() for s in female_pronouns] + [s.lower() for s in female_identifiers]]) else -1
    people[i-1][0] = (0 if any([True for name in people[i-1][1] if name.split(" ")[0].lower() in [s.lower() for s in male_pronouns] + [s.lower() for s in male_identifiers]]) else 2) if people[i-1][0] == -1 else people[i-1][0]


# remove pronouns
boring_pronouns = ["I", "my", "me", "myself", "you", "yourself"]
for i in range(len(people)):
   people[i-1][1] = [name for name in people[i-1][1] if name.lower() not in ([s.lower() for s in boring_pronouns] + [s.lower() for s in male_pronouns] + [s.lower() for s in female_pronouns])]

# remove duplicates
for person in people:
  person[1] = list(set(person[1]))

# PRETTYPRINT!
sorter = lambda x: x[2]
people.sort(key=sorter)
for i in range(len(people)):
  print("Person %s: gender=%s names=%s" % (people[i][2],"<unknown>" if people[i][0] == 2 else (("fe" if people[i][0] == 1 else "") + "male"), ", ".join(["<none>"] if len(people[i][1]) == 0 else sorted(people[i][1]))))
  