pos = input("My position: ")
fov = float(input("FOV angle: "))
pokemon = input("Pokémon: ")

# parse "x,y" into (x,y) tuple of ints
x,y = pos.split(",")
pos = (int(x),int(y))
result = []
if pokemon: # if there are pokemon on the grid
  # resolve angle of co-ordinate loc(x,y) in respect to the current position
  import math
  def getangle(loc):
    inrads = math.atan2(pos[1] - loc[1],loc[0] - pos[0])
    if (inrads < 0):
        inrads = abs(inrads)
    else:
        inrads = 2*math.pi - inrads
    return math.degrees(inrads)

  # parse each pokemon co-ordinate, also calculating its angle in respect to the current position
  pag = {}
  for pkmn in pokemon.split(" "):
    x, y = pkmn.split(",")
    xytuple = (int(x),int(y))
    angle = getangle(xytuple)
    pag[angle] = pag[angle] + [xytuple] if angle in pag else [xytuple]
  
  """ # orig but too slow - kept for sentimental value #
  for angle in pag:
    angles = [_angle for _angle in pag if betweenangle(_angle, angle, fov)]
    count = sum([len(pag[a]) for a in angles])
    if count > _count: result, _count = angles, count
  """
  result = []
  _count = 0
  
  _pag = sorted(pag)     
  for i in range(len(_pag)): # change reference angle
    angle = _pag[i]
    angles = []
    count = 0
    # loop angles from the current position to the last angle in the fov boundary
    for _angle in _pag[i:]+([v for v in _pag[:i] if v < angle+fov] if angle+fov>=360 else []):
      if _angle > angle + fov: break
      # check if the angle is inside the fov
      if any([angle <= _angle <= angle + fov, angle + fov >= 360 and (angle <= _angle <= 360 or 0 <= _angle <= (angle + fov)%360)]):
        angles.append(_angle)
        count += len(pag[_angle])
    if count > _count: result, _count = angles, count

  # output
  output = []
  [output.extend(pag[o]) for o in result]
  for x in sorted(output):
    print("%s,%s" % (x[0],x[1]))
