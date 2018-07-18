import re


def to_camel_case(text):
    text = re.split(r'[-_]', text)
    for i in range(1, len(text)):
        text[i] = text[i].capitalize()
    text = "".join(text)
    return text
