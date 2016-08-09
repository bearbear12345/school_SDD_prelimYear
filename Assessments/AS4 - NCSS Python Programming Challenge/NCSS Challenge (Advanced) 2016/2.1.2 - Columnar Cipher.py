key = input("Key: ")
message = input("Message: ")
import re
message_strip = re.sub(r'[^a-zA-Z]+', '', message)
if len(message.strip()) != 0:
  # Key Order
  tuplesort = lambda c: ord(c[0])
  keyg = []
  for i in range(len(key)):
    keyg.append((key[i],i))
  keygs = sorted(keyg,key=tuplesort)
  # Populate matrix
  matrix = [["" for _ in range(len(key))]]
  matrix_position = (0,0)
  for letter in message_strip:
    if matrix_position[0] == len(key):
      matrix_position = (0, matrix_position[1])
      matrix_position = (matrix_position[0], matrix_position[1] + 1)
      matrix.append(["" for _ in range(len(key))])
    matrix[matrix_position[1]][matrix_position[0]] = letter
    matrix_position = (matrix_position[0] + 1, matrix_position[1])

  # pad matrix
  for i in range(len(key)-matrix_position[0]):
    while i>25: i -= 26
    matrix[matrix_position[1]][matrix_position[0]] = chr(97+i)
    matrix_position = (matrix_position[0] + 1, matrix_position[1])

  # print columns in order of key order
  print("".join("".join([matrix[i][c[1]] for i in range(len(matrix))]) for c in keygs))
else:
  print()