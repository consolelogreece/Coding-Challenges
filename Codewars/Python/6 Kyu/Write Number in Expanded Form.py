def expanded_form(num):
    string = ""
    numlist = list(str(num))
    numListLength = len(numlist)
    for i in range(numListLength):
        if numlist[i] != "0":
            string += ((numlist[i]) + "0"*(numListLength - (i + 1)) + " + ")
    return string[0:len(string)-3]

print(expanded_form(9000000))