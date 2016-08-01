def is_square_palindrome(i):
  import math
  if not math.sqrt(i).is_integer(): return False
  i = str(i)
  if len(i) % 2 == 0: return False
  m = int((len(i)-1)/2)
  if i[:m] == i[m+1:][::-1]: return True
  return False