def array_diff(a, b):
    remove_queue = []
    if len(a) == 0 or len(b) == 0:
        return a
    for i in range(len(a)):
        for j in range(len(b)):
            if a[i] == b[j]:
                remove_queue.append(i)

    remove_queue.sort(reverse=True)

    for i in range(len(remove_queue)):
        del a[remove_queue[i]]
    return a


#testing stuff#
a = ([1, 2])
b = [1]
print(array_diff(a, b))