print("Hello World!\n")

name = raw_input("What is your name? ")
while not name:
    name = raw_input("What is your name? ")
print("Hello, %s!" % name)

import time
time.sleep(2)
