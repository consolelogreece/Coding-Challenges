def in_asc_order(arr):
    for i in range(1, len(arr)):
        if arr[i] < arr[i-1]:
            return False

    return True

//https://www.codewars.com/kata/56b7f2f3f18876033f000307