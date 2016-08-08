def lucky(n):
    l = list(range(1, n + 1))
    del(l[l[1] - 1::l[1]])
    for i in range(1, n + 1):
        if i < len(l):
            del(l[l[i] - 1::l[i]])
        else:
            continue
    return l[-1]
i = int(input("Enter number: "))
print(lucky(i))