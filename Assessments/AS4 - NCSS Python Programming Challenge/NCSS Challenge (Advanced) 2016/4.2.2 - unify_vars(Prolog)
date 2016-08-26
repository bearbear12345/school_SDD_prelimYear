import re
debug = False
def debugPrint(*args, **kwargs):
  if debug: print(*args, **kwargs)
dprint = debugprint

with open("program.pro") as f:
  inputs = [l.strip() for l in f] 
_vars = {}

def search(requery, key):
  if key in _vars:
    for item in _vars[key]:
      rematch = re.match(requery, item)
      if rematch: return rematch
  return false

def storevar(key, args):
  if key not in _vars: _vars[key] = [args]
  else: _vars[key].append(args)

for instruction in inputs:
  if instruction:
    isrule = true if instruction[:2] != "?-" else false
    instruction = re.sub(r'^\?- ?',"",instruction)
    key = instruction[:instruction.index("(")]
    args = instruction[instruction.index("(")+1:instruction.index(")")]
    if isrule:
      storevar(key, args)
      continue
    else:
      _map = {}
      i = 1

      for term in args.split(", "):
        if term not in _map:
          _map[term] = i
          i += 1

      requery = "^"
      used = []
      _termre = "([a-za-z][a-za-z0-9_]*)"
      for term in args.split(", "):
        #if not term.islower():
        if re.match(r'[a-z][a-za-z0-9_]*', term):
          if term not in used:
            requery += "%s, " % _termre
            used.append(term)
          else:
            requery += "\\%s, " % _map[term]
        else: requery += "%s, " % term
      requery = requery[:-2]+"$"
      rematch = search(requery, key)
      if rematch:
        if _termre not in str(rematch.re): print("yes")
        dprint(rematch)
        dprint(requery)
        loop = []
        matchcount = re.compile(requery).groups
        if matchcount: print("\n".join(sorted([used[i] + " = " + rematch.groups()[i] for i in range(matchcount)])))
      else:
        print("no")

"""
# David's code for sentimental value
dic = {}
out = []
names = []
# used = []

for lines in open("program.pro"):
  try:
    isRule = True
    lines = lines[:-3].split("(")
    if "?-" in lines[0]:
      isRule = False
    if isRule: # If it is a rule
      try:
        temp = dic[lines[0]]
      except:
        temp = []
      temp.append(lines[1].split(", "))
      #print(temp)
      dic[lines[0]] = temp
      for items in temp:
        if not items in names:
          names.append(items)
    else: # If it is a query
      possibleMatches = []
      key = lines[0][3:]
      values = lines[1].split(", ")
      for array in dic[key]:
        if values == array:
          out.append("yes")
        else:
          for i in range(len(values)):
            if values[i] == array[i] and not array in possibleMatches:
              possibleMatches.append(array)
      #for matches in possibleMatches:
        #if not matches in used: # If the first one is already used
      for i in range(len(possibleMatches[0])):
        if values[i] != possibleMatches[0][i]:
          out.append(values[i]+" = "+possibleMatches[0][i])
      if possibleMatches == []:
        out.append("no")
      print(possibleMatches)
  except:
    pass

#print(dic)
for x in out:
  print(x)
"""
