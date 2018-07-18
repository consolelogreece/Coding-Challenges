def riders(stations):
    riderstotal = 1
    currentRidersTravelDistance = 0
    for distance in stations:
        if (currentRidersTravelDistance + distance) <= 100:
            currentRidersTravelDistance += distance
        else:
            riderstotal+=1
            currentRidersTravelDistance = distance
    return riderstotal

//https://www.codewars.com/kata/5b18e9e06aefb52e1d0001e9