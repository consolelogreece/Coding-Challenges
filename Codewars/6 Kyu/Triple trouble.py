import re
def triple_double(num1, num2):
    listiter1 = (re.findall(r'(\d)\1+.', str(num1)))
    listeriter2 = (re.findall(r'(\d)\1+', str(num2)))

    for i in range(len(listiter1)):
        for j in range(len(listeriter2)):
            if listiter1[i] == listeriter2[j]:
                return 1
            else:
                continue
    return 0