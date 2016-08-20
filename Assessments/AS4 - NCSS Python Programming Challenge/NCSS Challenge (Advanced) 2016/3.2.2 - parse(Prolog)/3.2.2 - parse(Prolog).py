# bnf regex stub definitions
import re
bnf = {
         'term': r'<atom>|<variable>',
         'term_list': r'(<term>,)*<term>',
         'predicate': r'<atom>\(<term_list>\)',
         'predicate_list':r'(<predicate>,)*<predicate>',
         'rule': r'<predicate>\.|<predicate>:-<predicate_list>\.',
         'query': r'\?-<predicate>\.',
         'atom': r'[a-z][a-zA-Z0-9_]*',
         'variable': r'[A-Z][a-zA-Z0-9_]*',
         }

# merge rules
while any((True if "<" in bnf[rule] else False) for rule in bnf):
  try:
    for rule in bnf:
      for _rule in bnf:
        bnf[_rule] = bnf[_rule].replace("<"+rule+">", "("+bnf[rule]+")")
  except:
    pass

# "Each line of the program will be either a <rule> or a <query>."
rules = [bnf['rule'],bnf['query']]

try:
  with open("program.pro") as f:
    c = 0 # line counter
    for line in f:
      c += 1
      line = line.strip().replace(" ","")
      if len(line) == 0: continue # blank line
      if not any(re.match('^('+rule+')$', line) for rule in rules): raise
    print('Valid program!')
except:
  print("Invalid program on line %s!" % c)
