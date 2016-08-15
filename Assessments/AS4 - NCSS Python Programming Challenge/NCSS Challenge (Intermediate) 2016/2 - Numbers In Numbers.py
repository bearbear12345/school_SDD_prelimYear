# Jason

search = str(input('Search for: '))
searchrange = int(input('In range up to: '))
count = 0
for i in range(1,searchrange+1):
    if search in str(i):
        print(i, "contains", search)
        count += 1
print(count, "times")
