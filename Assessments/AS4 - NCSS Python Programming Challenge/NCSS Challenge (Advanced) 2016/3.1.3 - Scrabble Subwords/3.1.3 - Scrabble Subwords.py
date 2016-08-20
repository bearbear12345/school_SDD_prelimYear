# david
inputword = input("Enter a word: ").lower()
matchlist = []
checkedlist = []
 
def recursion(word):
  subwordlist = [word]
  for i in range(len(word)):
    subwordlist.append(word[:i] + word[i+1:])
  for line in open("words.txt"):
    line = line.lower().strip()
    if line in subwordlist and not line in matchlist and len(line) > 1:
      matchlist.append(line)
  for match in matchlist:
    if not match in checkedlist and match != word and len(match) > 2:
      checkedlist.append(match)
      recursion(match)
 
recursion(inputword)
matchlist = matchlist if inputword in matchlist else []
print(len(matchlist))