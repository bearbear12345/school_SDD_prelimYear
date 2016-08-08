import itertools
keywords = [''.join(i) for i in itertools.product(["!","1"], repeat = 3)]
msg = input("Line: ")
while msg:
  if any(word in msg.split(":",1)[1] for word in keywords): print(msg.split(":")[0],"is extremely excited!")
  msg = input("Line: ")