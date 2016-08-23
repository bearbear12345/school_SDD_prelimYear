import re
wl = {}
with open("words.txt") as f:
  for word in f:
    word=word.strip()
    if (len(word)-2) in wl: wl[len(word)-2].append(word)
    else: wl[len(word)-2] = [word]
_ = input("Line: ")
matches = []
while _:
  for item in re.findall(r'\b[A-Za-z](?:\d|[1-9]\d*)[A-Za-z]\b', _, flags=re.IGNORECASE):
    if item.lower() not in matches: matches.append(item.lower())
  _ = input("Line: ")
matches.sort()
for item in matches:
  prefix = item[0]
  suffix = item[-1]
  length = int(item[1:-1])
  results = []
  if length in wl:
    for word in wl[length]:
      if prefix == word[0] and suffix == word[-1]:
        results.append(word)
    results.sort()
  print("%s:" % item, ", ".join(results) if len(results) > 0 else "???")
  