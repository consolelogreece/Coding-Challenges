def is_turing_equation(s):
    array = s.split("+")
    a = array[0]
    [b,c] = array[1].split("=")
    a = int(a[::-1])
    b = int(b[::-1])
    c = int(c[::-1])
    return (a+b==c)

//https://www.codewars.com/kata/5a1e6323ffe75f71ae000026