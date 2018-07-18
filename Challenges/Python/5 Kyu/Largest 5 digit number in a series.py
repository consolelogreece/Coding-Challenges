def solution(digits):
    largestNo = 0
    for i in range(len(digits)):
        tempNo = int(digits[i:i+5])
        if tempNo > largestNo:
            largestNo = tempNo
    return largestNo;