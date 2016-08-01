def genbox(i):
  i = int(i)
  def draw(size, yc, xc):
    y = yc
    for _ in range(0,size):
      if _ == 0 or _ == size-1:        
        x = xc
        i = 0
        while i < size:
          if not g[_+y][x]=="x": g[_+y][x] = "x"
          x += 2
          i+=1
      else:
        if not g[_+y][xc]=="x": g[_+y][xc] = "x"
        if not g[_+y][(len(g[0])-xc-1)]=="x": g[_+y][(len(g[0])-xc-1)] = "x"
    pass
 
  g = []
  for _ in range(1,i+1):
    h = []
    for _ in range(1,2*i):
      h.append(" ")
    g.append(h)
  c = i
  a = 0
  b = 0
  while c > 0:
    draw(c,a,b)
    c -= 4
    a += 2
    b += 4
  output = ""
  for row in g:
    output += "".join(row) + "\n"
  return output.strip()
print(genbox(input("Enter size: ")))