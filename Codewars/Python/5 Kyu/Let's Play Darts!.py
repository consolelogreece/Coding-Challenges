import math
def get_score(x, y):


    bullseye_inner_ring_radius = 6.35
    bullseye_outer_ring_radius = 15.9
    triple_outer_ring_radius = 107
    triple_inner_ring_radius = 99
    double_inner_ring_radius = 162
    double_outer_ring_radius = 170
    returnstring = ""

    # Pythagoras' theorem. B_length is also the radius. Don't be confused by "hypot",
    # as it's the hypotenuse of the x and y of the dart position (aka, the length of C).
    radius = math.hypot(x, y)

 #================== Edge Cases ================
    if radius > double_outer_ring_radius:
        return "X"

    if radius <= bullseye_inner_ring_radius:
        return "DB"
    elif  bullseye_inner_ring_radius<=radius <= bullseye_outer_ring_radius:
        return "SB"
#===============================================
    signed = False
    if x < 0:
        signed = True






    """
                           /|
                          / |
                         /  |
                     A  /   |
                       /    |  B
                      /     |
                     /      |
                    /_______|
                        C
    A = distance between where the dart hit and the top of the board.                    
    B = distance between the top and the center of the board.
    C = distance between the center of the board and the where the dart hit.
    
    NOTE: TRIANGLES ARE NOT ALWAYS RIGHT ANGLES. I JUST CANT DRAW NON RIGHT-ANGLED TRIANGLES IN ASCII.
    
    """

    #coordinates

    center_of_board = {"x": 0, "y": 0}
    top_of_board = {"x": 0, "y": double_outer_ring_radius}
    dart_location = {"x": x, "y": y}

    A_length = math.sqrt(((x - top_of_board.get("x")) ** 2) + ((y - top_of_board.get("y")) ** 2))  # The Distance Formula.
    B_length = double_outer_ring_radius
    C_length = radius


    """
                           /|
                          / |
                         /  |
                    A   /   | B
                       /    |  
                      /     |
                     /      |
                    /_______| 
                        C    x
                        
    x = angle I need to calculate.
    A = length of side opposite the angle.
    B and C  = the lengths of the other sides.
    
    these are necessary for the cosine rule formula.

    """

    A_sqr = A_length ** 2
    B_sqr = B_length ** 2
    C_sqr = C_length ** 2

    bearing = math.degrees(math.acos((B_sqr + C_sqr - A_sqr) / (2 * B_length * C_length)))  # cosine rule

    if signed:
        bearing = 360 - bearing

    #Check if dart landed in a double or triple area
    if triple_inner_ring_radius <= radius <= triple_outer_ring_radius:
        returnstring += "T"
    elif double_inner_ring_radius <= radius <= double_outer_ring_radius:
        returnstring += "D"

    #use bearing to determine which number dart landed in.
    ####REFACTOR THIS. FIND BETTER WAY TO DETERMINE NUMBER####
    if bearing <= 9 or bearing >= 351:
        returnstring += "20"
    elif 9 <= bearing <= 27:
        returnstring += "1"
    elif 27 <= bearing <= 45:
        returnstring += "18"
    elif 45 <= bearing <= 63:
        returnstring += "4"
    elif 63 <= bearing <= 81:
        returnstring += "13"
    elif 81 <= bearing <= 99:
        returnstring += "6"
    elif 99 <= bearing <= 117:
        returnstring += "10"
    elif 117 <= bearing <= 135:
        returnstring += "15"
    elif 135 <= bearing <= 153:
        returnstring += "2"
    elif 153 <= bearing <= 171:
        returnstring += "17"
    elif 171 <= bearing <= 189:
        returnstring += "3"
    elif 189 <= bearing <= 207:
        returnstring += "19"
    elif 207 <= bearing <= 225:
        returnstring += "7"
    elif 225 <= bearing <= 243:
        returnstring += "16"
    elif 243 <= bearing <= 261:
        returnstring += "8"
    elif 261 <= bearing <= 279:
        returnstring += "11"
    elif 279 <= bearing <= 297:
        returnstring += "14"
    elif 297 <= bearing <= 315:
        returnstring += "9"
    elif 315 <= bearing <= 333:
        returnstring += "12"
    elif 333 <= bearing <= 351:
        returnstring += "5"

    return returnstring


##test stuff##
print(get_score(55.53, -87.95))






