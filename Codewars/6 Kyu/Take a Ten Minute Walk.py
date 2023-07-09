def isValidWalk(walk):
    currentpos = [0, 0]
    if len(walk) != 10:
        return False

    for steps in walk:
        if steps == "n":
            currentpos[0] += 1

        elif steps == "e":
            currentpos[1] += 1
        elif steps == "s":
            currentpos[0] -= 1
        elif steps == "w":
            currentpos[1] -= 1

        if currentpos[0] == 0 and currentpos[1] == 0:
            return True
        else:
            return False
        
