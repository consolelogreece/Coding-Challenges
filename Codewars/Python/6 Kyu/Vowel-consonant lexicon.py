def solve(s):
    vowels = []
    consonants = []
    vowelcheck = ["a", "e", "i", "o", "u"]
    arr = list(s)

    for i in range(len(arr)):

        if arr[i] in vowelcheck:
            vowels.append(arr[i])
        else:
            consonants.append(arr[i])

    vowels = sorted(vowels)
    consonants = sorted(consonants)

    difference = ((len(vowels)) - (len(consonants)))
    string = ""

    if difference == 1:
        while 1:
            string += vowels[0]
            del vowels[0]
            if len(consonants) == 0:
                break
            else:
                string+= consonants[0]
                del consonants[0]


    elif difference == -1:
        while 1:
            string += consonants[0]
            del consonants[0]
            if len(vowels) == 0:
                break
            else:
                string += vowels[0]
                del vowels[0]

    elif difference == 0:
        for k in range(len(consonants)):
            string += vowels[k]
            string += consonants[k]



    else:
        return "failed"

    return string