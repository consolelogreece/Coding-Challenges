using System;
using System.Collections.Generic;

class Kata
{
    public static string JumpingNumber(int number)
    {
        
        int[] digits = digitArr(number);
        
        for(int i = 1; i < digits.Length; i++) if(Math.Abs(digits[i] - digits[i - 1]) != 1 ) return "Not!!";
        
        return "Jumping!!";
    }
    
    public static int[] digitArr(int n)
    {
        var digits = new List<int>();
    
        for (; n != 0; n /= 10)
            digits.Add(n % 10);
    
        var arr = digits.ToArray();
        Array.Reverse(arr);
        return arr;
    }
}

//https://www.codewars.com/kata/5a54e796b3bfa8932c0000ed