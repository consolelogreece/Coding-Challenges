def cup_and_balls(b, arr):
    for move in arr:
        if (move[0] == b): b= move[1];
        elif (move[1] == b): b = move[0];
        
    return b;

//https://www.codewars.com/kata/5b715fd11db5ce5912000019