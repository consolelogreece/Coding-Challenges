def title_case(title, minor_words=''):
    split_minor_words = minor_words.split(" ")
    #if len(title) == 0 or len(minor_words) == 0:
        #return ""
    words = title.split(" ")
    isMinor = False
    retval = words[0].title()
    for word in words[1:]:
        for minor in split_minor_words:
            if word.lower() == minor.lower():
                isMinor = True
                break
        if isMinor:
            retval += " " + word.lower()
            isMinor = False
        else:
            retval += " " + word.title()
            isMinor = False

    return retval