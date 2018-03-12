def move_zeros(array):
    count = len(array)
    i = 0
    while i < count:
        if array[i] == 0:
            if type(array[i]) == bool:
                i += 1
            else:
                array.append(array.pop(i))
                count -= 1

        else:
            i += 1

    return array

print(move_zeros(["a",0,0,"b",None,"c","d",0,1,False,0,1,0,3,[],0,1,9,0,0,{},0,0,9]))
#print (move_zeros([9,0.0,0,9,1,2,0,1,0,1,0.0,3,0,1,9,0,0,0,0,9]))