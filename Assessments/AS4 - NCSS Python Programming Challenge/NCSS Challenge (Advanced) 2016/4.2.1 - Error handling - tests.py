
if __name__ == '__main__':
  """
  Write your code to test your Node class here. Any code inside the __name__ == '__main__'
  check will not affect the marking.
  """
  # Construct the Node objects.
  n0 = Node('n0')
  n1 = Node('n1')
  n2 = Node('n2')
  n3 = Node('n3')
  n4 = Node('n4')
  # Form the tree structure.
  n0.add_child(n1)
  n0.add_child(n2)
  n1.add_child(n3)
  # Inspect the tree.
  assert n0.has_descendant(n1)
  assert n1.has_ancestor(n0)
  assert n0.has_descendant(n2)
  assert n2.has_ancestor(n0)
  assert n1.has_descendant(n3)
  assert n3.has_ancestor(n1)
  assert n0.has_descendant(n3)
  
  print("\npprint method")
  n0 = Node('node zero')
  n1 = Node('node one')
  n2 = Node('node two')
  print(n0.pprint())
  print(n0)
  print(n1.pprint())
  print(n1)
  print(n2.pprint())
  print(n2)

  print("\nget_count method")
  n0 = Node('n0')
  n1 = Node('n1')
  n2 = Node('n2')
  n3 = Node('n3')
  n4 = Node('n4')
  n0.add_child(n1)
  n0.add_child(n2)
  n1.add_child(n3)
  print(n4.get_count())
  print(n3.get_count())
  print(n2.get_count())
  print(n1.get_count())
  print(n0.get_count())
  
  print("\nget_height method")
  n0 = Node('n0')
  n1 = Node('n1')
  n2 = Node('n2')
  n3 = Node('n3')
  n4 = Node('n4')
  n0.add_child(n1)
  n0.add_child(n2)
  n1.add_child(n3)
  print(n4.get_height())
  print(n3.get_height())
  print(n2.get_height())
  print(n1.get_height())
  print(n0.get_height())
  
  print("\nChild that is not a node test case")
  n0 = Node('n0')
  n1 = Node('n1')
  n2 = 'n2'
  n3 = 3
  try:
    n0.add_child(n1)
  except:
    print('Exception should not be raised!')
  else:
    print('Correctly did not throw an exception.')
  try:
    n0.add_child(n2)
  except TypeError:
    print('Exception correctly raised.')
  except:
    print('Wrong exception!')
  else:
    print('Did not throw an exception.')
  try:
    n0.add_child(n3)
  except TypeError:
    print('Exception correctly raised.')
  except:
    print('Wrong exception!')
  else:
    print('Did not throw an exception.')
    
  print("\nChild that is None")
  n0 = Node('n0')
  n1 = Node('n1')
  try:
    n0.add_child(n1)
  except:
    print('Exception should not be raised!')
  else:
    print('Correctly did not throw an exception.')
  try:
    n0.add_child(None)
  except ValueError:
    print('Exception correctly raised.')
  except:
    print('Wrong exception!')
  else:
    print('Did not throw an exception.')