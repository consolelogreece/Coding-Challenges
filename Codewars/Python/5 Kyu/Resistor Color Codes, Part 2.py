import re
def encode_resistor_colors(ohms_string):
    N = 0  #  N = power/order of magnitude. ie. x10^N
    colors = {"0": "black", "1": "brown", "2": "red", "3": "orange", "4": "yellow", "5": "green", "6": "blue", "7": "violet", "8": "gray", "9": "white"} # color hash table
    holder = ohms_string.split(" ")
    number = holder[0]
    checkForNonNumeric = r'\D'
    checkForFloat = r'\.'


    if re.search(checkForFloat, number): # if the number is a float, make N -1 and remove the decimal point
        print("float detected")
        N = -1
        number = re.sub(checkForFloat, "", number)


    matches = re.search(checkForNonNumeric, number) # check for a non numeric character and assign the first non numeric char found to matches variable
    number = re.sub(checkForNonNumeric, "", number) # remove non numeric characters
    number = list(number) # convert number string into list

    N += determineN(matches, number) # determines N,
    N = str(N) # converts N to a string


    fstring = colors.get(number[0], colors["0"]) + " " + colors.get(secondVal(number), colors["0"]) + " " + colors.get(N, colors["0"]) + " gold"
    return fstring


def secondVal(number):  # determines whether there is more than one number in number list. if there is, return the number in that index, if not, return "0"

    if len(number) >= 2:
        return number[1]
    else:
        return "0"


def determineN(matches, number): # determines N
    n = 0
    if len(number) == 1:  # distinguishes difference between single digit and double digit by removing 1 from N if single digit
        n -= 1
    elif len(number) > 2: # distinguishes difference between double digit and triple or more digit by adding the length of number list - 2
        n += (len(number) - 2)

    if isinstance(matches, type(None)):
        pass
    else:
        if matches.group() == "k":
            n += 3
        elif matches.group() == "M":
            n += 6
    return n

print(encode_resistor_colors("100k"))