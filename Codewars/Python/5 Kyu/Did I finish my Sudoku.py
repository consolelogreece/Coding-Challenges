def done_or_not(board):  # board[i][j]
    for list in board:
        a = set(list)
        if len(a) != 9:
            return "Try again!"
    lister = []
    for i in range(len(board[0])):
        templist = []

        for j in range(len(board)):
            templist.append(board[j][i])
        lister.append(templist)

    for list in lister:
        a = set(list)
        if len(a) != 9:
            return "Try again!"

    answer = []
    for r in range(3):
        for c in range(3):
            block = []
            for i in range(3):
                for j in range(3):
                    block.append(board[3*r + i][3*c + j])
            answer.append(block)

    for block in answer:
        a = set(block)
        if len(a) != 9:
            return "Try again!"
    return "Finished!"