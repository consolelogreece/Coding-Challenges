def unique_in_order(iterable):
    length = len(iterable)
    order = []
    for i in range(length):
        if i == 0 or iterable[i] != iterable[(i-1)]:
            order.append(iterable[i])
    return (order)