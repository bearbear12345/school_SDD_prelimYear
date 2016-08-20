# maximum [int(X),int(Y)]
maximum = [0,0]
def updateMax(isXval,val):
  global maxmimum
  if isXval: maximum[0] = max(val,maximum[0])
  else: maximum[1] = max(val,maximum[1])
    
#tree = ("hello", (("a", ()), ("b", (("cde", ()), ("fg", ())))))
#tree = ("supercalifragilisticexpialidocious",(("a", (("b",(("candy",()),)),("onomatopoeia",()),)),("d",(("egg",(("f",()),)),)),))

tree = eval(input('Enter tree: '))

# Change tuple input into a dictionary
treedict = {}
def analyse(tpl,writeto=treedict,level=1):
    updateMax(False,level)
    label, children = tpl
    writeto['label'] = label
    writeto['nodes'] = []
    for i in range(len(children)):
      writeto['nodes'].append({})
      analyse(children[i],writeto['nodes'][i],level+1)
    writeto['len'] = max(sum([node['len'] for node in writeto['nodes']]),len(writeto['label'])+2)
    updateMax(True,writeto['len'])
analyse(tree)

# [WORD___]
def pad(string, length=0):
  return "["+string+"_"*(length-2-len(string))+"]"

# Create the output matrix
matrix = [["." for  _ in range(maximum[0])] for _ in range(maximum[1])] 

# Populate matrix with strings
def updateMatrix(content, x, y):
  global matrix
  for character in content:
    matrix[y][x] = character
    x += 1

# loop-dee-doo
def draw(dictobject,x=0,y=0):
  _label = dictobject['label']
  _len = dictobject['len']
  _nodes = dictobject['nodes']
  updateMatrix(pad(_label, _len),x,y)
  offset = 0
  for node in _nodes:
    draw(node,offset+x,y+1)
    offset += node['len']
draw(treedict)

print("\n".join(["".join([c for c in r]) for r in matrix]))