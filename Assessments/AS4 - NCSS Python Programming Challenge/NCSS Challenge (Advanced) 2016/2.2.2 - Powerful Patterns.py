import re
with open("words.txt") as f:
  for word in f.readlines():
    if re.match(r'^(t|m)(?:[^euioa]|[euioa](?![euioa]))*y$', word.strip(), flags=re.IGNORECASE) != None: print(word.strip())