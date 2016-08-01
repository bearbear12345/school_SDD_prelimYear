with open("sms-phrases.txt") as f:
  phrases = {}
  for x in f.readlines():
    a,b = x.strip().split(" ",1)
    phrases[a.lower()] = b
with open("sms-message.txt") as f:
  for line in f.readlines():
    line = line.strip().lower()
    for x in phrases:
      line = line.replace(x,phrases[x])
    print(line)