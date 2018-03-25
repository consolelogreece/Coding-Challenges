def convert_char_to_six_bit_binary(string):

    decimalbinstring = ""
    decimalbinarray = []
    for char in string:
        # Convert each character (ASCII) into its binary form,
        # and add them into the array in groups of 3 (3 x 8 bin ints).
        # use zfill to keep each integer 8 bits long
        decimalbinstring += (bin(ord(char))[2:]).zfill(8)

    decimalbinstring_len = len(decimalbinstring)  # stores length of the binary string for future use.

    remainder = decimalbinstring_len % 6  # calculates remainder. this is needed for padding.

    for i in range(decimalbinstring_len)[:-5:6]:
        # loops through the string of binary, and splits them up into strings of length 6, and appends those to array.
        decimalbinarray.append(
            decimalbinstring[i] + decimalbinstring[i + 1] + decimalbinstring[i + 2] + decimalbinstring[i + 3] +
            decimalbinstring[i + 4] + decimalbinstring[i + 5])

    if remainder != 0:
        # if remainder doesn't equal 0, padding is necessary.
        tempstring = ""

        for i in range((decimalbinstring_len - remainder), decimalbinstring_len):
            tempstring += decimalbinstring[i]
        tempstring += ("0" * (6 - remainder))  # pads the remaining decimals with zeros. i.e. '01' becomes '010000'
        decimalbinarray.append(tempstring)

    return decimalbinarray


def binary_to_decimal(number):
    result = 0
    for bit in number:
        result *= 2
        if bit == '1':
            result += 1
    return result


def binary_array_to_decimal(array):
    int_array = []
    for entry in array:
        int_array.append(binary_to_decimal(entry))
    return int_array


def decimal_to_base64_char(array):
    b64 = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789+/"
    returnString = ""
    for decimal in array:
        returnString += b64[decimal]
    return returnString


def convert_char_to_eight_bit_binary(string):
    b64 = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789+/"
    base128binstring = ""
    base128binarray = []
    for char in string:
        # Convert each character (ASCII) into its binary form,
        # and add them into the array in groups of 3 (3 x 6 bin ints).
        # use zfill to keep each integer 8 bits long
        base128binstring += (bin(b64.index(char))[2:]).zfill(6)

    decimalbinstring_len = len(base128binstring)  # stores length of the binary string for future use.

    remainder = decimalbinstring_len % 8  # calculates remainder. this is needed for padding.

    for i in range(decimalbinstring_len)[:-7:8]:
        # loops through the string of binary, and splits them up into strings of length 6, and appends those to array.
        base128binarray.append(
            base128binstring[i] +  base128binstring[i + 1] +  base128binstring[i + 2] +  base128binstring[i + 3] +
            base128binstring[i + 4] +  base128binstring[i + 5] +  base128binstring[i + 6] +  base128binstring[i + 7])



    return base128binarray



def decimal_to_base128_char(array):
    returnString = ""
    for decimal in array:
        returnString += chr(decimal)
    return returnString



def to_base_64(string):
    pad = False  # if true, apply padding.
    base64binarray = convert_char_to_six_bit_binary(string)  # converts the string into 6 bit binary (base64)
    decimalarr = binary_array_to_decimal(base64binarray)  # converts the binary into decimals
    base64string = decimal_to_base64_char(decimalarr)  # converts the decimals into chars using base64 character table

    if pad:
        mod_3 = len(string) % 3
        if mod_3 != 0:
            base64string += ("=" * (3 - mod_3))

    return base64string



def from_base_64(string):
    base128binarray = convert_char_to_eight_bit_binary(string.replace("=", "")) #converts string to 8 bit binary (base128), also removes "=" from potential padding
    decimalarr = binary_array_to_decimal(base128binarray)  # converts binary integers into decimal integer array
    base128string = decimal_to_base128_char(decimalarr)  # converts decimal value into ascii char

    return base128string

