##rot13 cipher encryption##

def rot13(message):
    messageList = list(message);
    print(messageList)
    for i in range(len(messageList)):
        print(messageList[i])
        charcode = ord(messageList[i])
        print(charcode)
        if 90 >= charcode >= 65:
            charcode += 13
            if charcode > 90:
                charcode -= 26
            messageList[i] = chr(charcode)
        elif 122 >= charcode >= 97:
            charcode += 13
            if charcode > 122:
                charcode -= 26
            messageList[i] = chr(charcode)
    return "".join(messageList)

##test stuff##
print(rot13("grfg"))