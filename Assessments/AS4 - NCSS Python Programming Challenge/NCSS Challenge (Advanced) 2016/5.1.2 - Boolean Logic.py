from node import Node

class AndNode(Node):
  def __init__(self, node1, node2):
    self._children = [node1, node2]
    pass
  def evaluate(self, variables):
    return False not in [self._children[0].evaluate(variables), self._children[1].evaluate(variables)]
  def get_children(self):
    return self._children
  def get_description(self):
    return "AND"
  
class OrNode(Node):
  def __init__(self, node1, node2):
    self._children = [node1, node2]
    pass
  def evaluate(self, variables):
    return any([self._children[0].evaluate(variables),self._children[1].evaluate(variables)])
  def get_children(self):
    return self._children
  def get_description(self):
    return "OR"

class NotNode(Node):
  def __init__(self, node):
    self._children = [node]
    pass
  def evaluate(self, variables):
    return not self._children[0].evaluate(variables)
  def get_children(self):
    return self._children
  def get_description(self):
    return "NOT"

class VariableNode(Node):
  def __init__(self, value):
    self._value = value
    pass  # TODO
  def evaluate(self, variables):
    return variables[self._value]
  def get_children(self):
    return []
  def get_description(self):
    return self._value
  def pprint(self, out, depth):
    return out + (' ' if depth != 0 else '') + self.get_description()

if __name__ == '__main__':
  # This represents "x AND y".
  e = AndNode(VariableNode('x'), VariableNode('y'))
  print(e)
  print(e.evaluate({'x': True, 'y': False, 'z': False}))
  print(e.evaluate({'x': True, 'y': True}))
  print(e.evaluate({'x': False, 'y': False, 'foo': True}))
  
  # This represents "bar OR NOT foo".
  e = OrNode(VariableNode('bar'), NotNode(VariableNode('foo')))
  print(e)
  print(e.evaluate({'bar': False, 'foo': True}))

  # This represents "x OR NOT (y AND (x OR z))".
  e = OrNode(VariableNode('x'), NotNode(AndNode(VariableNode('y'), OrNode(VariableNode('x'), VariableNode('z')))))
  print(e)
  print(e.evaluate({'x': True, 'y': False, 'z': False, 'a': True}))
  print(e.evaluate({'x': False, 'y': False, 'z': False, 'a': True}))
