using System;

public class Kata
{
    public static int[] CountPositivesSumNegatives(int[] input)
    {
        if (input == null || input.Length == 0) return new int[0];
        
        int nPos = 0;
        int sumNeg = 0;
        
        foreach(int n in input)
        {
          if (n <= 0) sumNeg += n;
          else nPos++;
        }
        
        return new int[]{nPos, sumNeg};
    }
}

// https://www.codewars.com/kata/576bb71bbbcf0951d5000044