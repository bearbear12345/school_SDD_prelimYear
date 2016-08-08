/*
This is a multi-line comment
*/

// This is a one-line comment

print("Hel" + "lo") // Concatenate strings

var number = 2
print(number + 1) // 3

var array = ["A", "B", "C"]
print("Number of items in array: " + array.length)
print("First item is array: " + array[0]) // Items begin from ZERO

if (array[0] == "A") {
	print("Item 1 in array is A")
} else {
	print("Item 1 in array is NOT A")
}

print("Item 1 in array is " + (array[0] == "A" ? "" : "NOT ") + "A")