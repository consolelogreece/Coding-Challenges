#include <vector>

std::vector<int> tribonacci(std::vector<int> signature, int n)
{
    for (int i = 0; i < n-3; i++) signature.push_back(signature[i] + signature[i+1] + signature[i+2]);
    return std::vector<int>(signature.begin(), signature.begin() + n);
}

//https://www.codewars.com/kata/556deca17c58da83c00002db