using System;
using System.Collections.Generic;

public static class FizzBuzz
{
    public static string[] GetFizzBuzzArray(int n)
    {
        if (n <= 0) throw new ArgumentOutOfRangeException();
        string[] arr = new string[n];

        for (int i = 1; i <= n; i++)
            arr[i - 1] = GetWord(i);

        return arr;
    }

    private static string GetWord(int n)
    {
        string result = "";
        
        if (n % 3 == 0) result += "Fizz";
        
        if (n % 5 == 0) result += "Buzz";
        
        if (result == "") result = n.ToString();
        
        return result;
    }
}

//https://www.codewars.com/kata/5300901726d12b80e8000498