--[[
This is a multi-line comment
--]]

-- This is a single-line comment

print("Hel" .. "lo") -- Concatenate strings

local number = 2
print(number + 1) -- 3

local array = {"A", "B", "C"}
print("Number of items in array: " .. #array)
print("First item is array: " .. array[1]) -- Items begin from ONE

if array[1] == "A" then
    print("Item 1 in array is A")
else
    print("Item 1 in array is NOT A")
end