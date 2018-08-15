import math

#Essentially an iterative binary search.
def index_equals_value(arr):
    low = 0; high = len(arr) - 1; lowestIndex = -1;

    while (low <= high):
        mid = math.floor((low + high) / 2);
        if (arr[mid] == mid): lowestIndex = mid;
        if (arr[mid] >= mid): high = mid - 1;
        else: low = mid + 1;

    return lowestIndex;

//https://www.codewars.com/kata/5b7176768adeae9bc9000056