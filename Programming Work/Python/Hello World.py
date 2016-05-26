#!/usr/bin/env python

print("Hello World!\n")

name = input("What is your name? ")
while not name:
    name = input("What is your name? ")
print("Hello, %s!" % name)