def digitize(n):
    digiString = str(n)[::-1];
    digits = [];
    for digiChar in digiString:
        digits.append(int(digiChar));
    return digits;

# https://www.codewars.com/kata/5583090cbe83f4fd8c000051