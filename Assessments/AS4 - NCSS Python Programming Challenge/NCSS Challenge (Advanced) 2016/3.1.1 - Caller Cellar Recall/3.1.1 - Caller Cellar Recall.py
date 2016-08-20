#with open('words.txt') as f:
#  l = [s.strip() for s in f.readlines()]
#  ignore = []
#  final = []
#  while l:
#    orig = sorted(l[0])
#    output = []
#    for item in l:
#      if sorted(orig) == sorted(item) and item not in ignore:
#        output.append(item)
#        ignore.append(item)
#    del l[0]
#    a = " ".join(sorted(output)) if len(output) > 1 else ""
#    if len(a.strip()) != 0:
#      final.append(a)
#  print("\n".join(sorted(final)).strip())

file = open("words.txt")
sortedList = lambda x: [sorted(z) for z in x]
matrix = []
for word in file:
  added = False
  word = word.strip()
  for line in matrix:
    if sorted(word) in sortedList(line):
      line.append(word)
      added = True
    line.sort()
  if not added:
    matrix.append([word])
      
        
for line in matrix:
  if len(line) > 1:
    print(" ".join(line))