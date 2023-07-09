import math
def find_next_square(sq):
    sr=math.sqrt(sq)
    return -1 if (sr-int(sr)!=0) else (sr+1) * (sr+1)

//https://www.codewars.com/kata/56269eb78ad2e4ced1000013