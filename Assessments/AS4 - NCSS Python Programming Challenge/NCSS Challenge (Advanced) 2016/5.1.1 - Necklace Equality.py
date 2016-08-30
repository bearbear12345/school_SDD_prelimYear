# Create variants of an arrangement, including reflections
""" Example
Input = "abcdef"
Output = ["abcdef", "fedcba", "bcdefa", "afedcb", "cdefab", ...]
"""
def wordVariants(word):
  result = []
  for i in range(len(list(word))):
    if word not in result:
      result.append(word)
      result.append(word[::-1])
    word = word[1:]+word[0]
  return result

# Collect arrangements
necklaces = []
necklace = input("Necklace: ")
while necklace:
  necklaces.append(necklace)
  necklace = input("Necklace: ")

# Add arrangements into dictionary
necklaceDict = {}
for necklace in necklaces:
  found = False
  for necklaceGroup in necklaceDict:
    if necklace in wordVariants(necklaceGroup): # Check the necklace arrangement exists
      found = True
      necklaceDict[necklaceGroup].append(necklace)
      break
  if not found: # New arrangement!
    necklaceDict[necklace] = [necklace]    

for identifier in sorted(necklaceDict, key=lambda x: -len(necklaceDict[x])):
  print(" ".join(sorted(necklaceDict[identifier])))
