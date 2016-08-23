# Woo go team
# Yeah. Single player challenge? na
# David x Andrew
# jks
# Good job David for the bulk of the code!

import re
ruleset = {}
out = []
line = "0"
replacements = True
terminals = []

while True:
  line = input("Rule: ")
  if line == "":
    break
  line = line.split(" ::= ")
  ruleset[line[0]] = line[~0]

while replacements:
  replacements = False
  for rule in ruleset:
    v = ruleset[rule].split(" | ")
    for _rule in ruleset:
      tempvalue = ruleset[_rule].split(" | ")
      for key,value in enumerate(tempvalue):
        tv = []
        isInValue = False
        m = value.split(" ")
        for p in m:
          if p == rule:
            replacements = True
            isInValue = True
            # print("---=",v)
            tv = [re.sub(r'\b%s\b' % rule, x, value, 1) for x in v] # Fixed! - Andrew
            # print(value, tv)
        if isInValue:
          tempvalue[key] = " | ".join(tv)
      ruleset[_rule] = " | ".join(tempvalue)

items = ruleset["S"].split(" | ")
for item in items:
  if not item in out and not item in terminals:
    out.append(item)
    
for i in out:
  print(i)