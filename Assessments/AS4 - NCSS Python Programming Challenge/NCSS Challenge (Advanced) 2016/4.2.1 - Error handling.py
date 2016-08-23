class Node:
  def __init__(self, label):
    """Initialise a node with a given label."""
    self._children = []
    self._parent = None
    self._label = label
    pass

  def __str__(self):
    return self.pprint()

  def add_child(self, child):
    if not child: raise ValueError
    if not isinstance(child, Node): raise TypeError
    if child._parent != None or child in self._children: raise ValueError
    child._parent = self
    self._children.append(child)
    """
    Add a child node to the current node.
    * raises ValueError if child is None.
    * raises TypeError if child is not a Node object.
    * raises ValueError if child is already a child of the current node.
    * raises ValueError if child already has its parent set.
    """
    pass  # TODO

  def get_count(self,l=1):
    """Returns how many nodes are in the tree."""
    result = sum([x.get_count(l+1) for x in self._children],len(self._children))
    return result+1 if l==1 else result

  def get_height(self,l=1,o=None):
    """Returns the height of the tree."""
    if o:
      o.maxdepth = max(o.maxdepth, l)
    else:
      self.maxdepth = 1
    for child in self._children:
      child.get_height(l+1,o or self)
    try:
      return self.maxdepth  # TODO
    except:
      return False

  def get_label(self):
    """Returns the label of the current node."""
    return self._label

  def get_parent(self):
    """Returns the parent of the current node. Returns None if node does not have a parent."""
    return self._parent

  def has_ancestor(self, node):
    """Returns whether or not the current node has 'node' as an ancestor."""
    try:
      return node.has_descendant(self)
    except:
      return False

  def has_descendant(self, node):
    """Returns whether or not the current node has 'node' as a descendant."""
    try:
      return any([True if child.has_descendant(node) else False for child in self._children]) or node in self._children
    except:
      return False

  def pprint(self,l=1):
    """Returns a string containing a nested 2-element list representation of the tree."""
    result = []
    for i in range(len(self._children)):
      if isinstance(self._children[i], Node):
        result.append(self._children[i].pprint(l+1))
    return str([self.get_label(), result]).replace("'", "\"") if l==1 else [self.get_label(), result]
