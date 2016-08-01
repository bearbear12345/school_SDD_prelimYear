_ = input("ABN: ")
try:
  _ = str(_)
  if len(_) != 11:
    raise
  a = []
  for x in _:
    a.append(int(x))
  a[0] = a[0] - 1
  f = 0
  w = [10,1,3,5,7,9,11,13,15,17,19]
  for x in a:
    f += x*w.pop(0)
  if f%89 == 0:
    print("Valid")
  else:
    raise()
except:
  print("Invalid")