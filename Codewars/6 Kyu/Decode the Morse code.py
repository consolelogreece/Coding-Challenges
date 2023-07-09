def decodeMorse(morse):
    returned = ""
    morse = [word.split(' ') for word in morse.split('   ')]
    for lists in morse:
        for lister in lists:
            if not len(lister) == 0:
                returned += (MORSE_CODE[lister])  #MORSE_CODE IS GIVEN IN THE CODEWARS CHALLENGE: https://www.codewars.com/kata/decode-the-morse-code/train/python
        returned += " "
    return returned.strip()