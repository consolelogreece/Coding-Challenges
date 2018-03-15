import math
def get_score(x, y):

    bullseye_inner_ring_radius = 6.35
    bullseye_outer_ring_radius = 15.9
    triple_outer_ring_radius = 107
    triple_inner_ring_radius = 99
    double_inner_ring_radius = 162
    double_outer_ring_radius = 170
    segment_size_degrees = 18
    signed = False
    score = ""

    # Pythagoras' theorem. B_length is also the radius. Don't be confused by "hypot",
    # as it's the hypotenuse of the x and y of the dart position (aka, the length of C).
    radius = math.hypot(x, y)

    # =============== BullsEye Check ===============
    if radius > double_outer_ring_radius:
        return "X"

    if radius <= bullseye_inner_ring_radius:
        return "DB"
    elif bullseye_inner_ring_radius <= radius <= bullseye_outer_ring_radius:
        return "SB"
    # ===============================================

    # Check if x value is positive or negative.
    if x < 0:
        signed = True     

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
                        
    x = Bearing. I need to work it out so I can determine which segment of the board the dart landed in.
    A = Distance between where the dart hit and the top of the board.                    
    B = Distance between the top and the center of the board.
    C = Distance between the center of the board and the where the dart hit.
    
    NOTE: TRIANGLES ARE NOT ALWAYS RIGHT ANGLES. I JUST CANT DRAW NON RIGHT-ANGLED TRIANGLES IN ASCII.
    
    All of these values are necessary for the cosine rule formula, and the distance formula.

    """

    # coordinates

    center_of_board = {"x": 0, "y": 0}
    top_of_board = {"x": 0, "y": double_outer_ring_radius}
    dart_location = {"x": x, "y": y}

    A_length = math.sqrt(((x - top_of_board.get("x")) ** 2) + ((y - top_of_board.get("y")) ** 2))  # The Distance Formula.
    B_length = double_outer_ring_radius
    C_length = radius

    A_sqr = A_length ** 2
    B_sqr = B_length ** 2
    C_sqr = C_length ** 2

    bearing = math.degrees(math.acos((B_sqr + C_sqr - A_sqr) / (2 * B_length * C_length)))  # The Cosine Rule.

    # Check if x is signed (a negative number).
    # If this wasn't done, there would be no way to determine if the dart was on the right.
    # or left side of the center.
    if signed:
        bearing = 360 - bearing

    # Check if dart landed in a double or triple area.
    if triple_inner_ring_radius <= radius <= triple_outer_ring_radius:
        score += "T"
    elif double_inner_ring_radius <= radius <= double_outer_ring_radius:
        score += "D"

    # In the format [i, j], this contains the lower bound of a bearing, i, and the segment value, j.
    bearings_to_segments = [[-9, 20], [9, 1], [27, 18],[45, 4], [63, 13], [81, 6], [99, 10], [117, 15],
                            [135, 2], [153, 17], [171, 3], [189, 19], [207, 7], [225, 16], [243, 8],
                            [261, 11], [279, 14], [297, 9], [315, 12], [333, 5]]

    # Use bearings_to_segments to determine which number dart landed in.
    # Subtracting the value of segment size is necessary, as otherwise the every dart will be shifted by one.
    # Segment around the dart board.
    for i, j in bearings_to_segments:
        if (bearing - segment_size_degrees) <= i:
            score += str(j)
            return score

    score += "20"
    return score
