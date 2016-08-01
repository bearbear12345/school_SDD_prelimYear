i = int(input("Enter a number: "))
j = int(str(i)[-2:])
if j > 10 and j < 14:
  print(str(i)+"th")
else:
  i = str(i)
  if i[-1] == "1":
    print(i + "st")
  elif i[-1] == "2":
    print(i + "nd")
  elif i[-1] == "3":
    print(i + "rd")
  else:
    print(i + "th")