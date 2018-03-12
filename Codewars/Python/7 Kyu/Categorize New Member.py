def openOrSenior(data):
    member_status = []
    for members in data:
        if members[0] >= 55 and members[1] > 7:
            member_status.append("Senior")
        else:
            member_status.append("Open")
    return member_status




#test stuff#
data = [[18, 20],[45, 2],[61, 12],[37, 6],[21, 21],[78, 9]]


print(openOrSenior(data))