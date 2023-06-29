using System.Linq;
using System;
using System.Collections.Generic;
public static class Kata
{
    public static int IsInteresting(int number, List<int> awesomePhrases)
    {
      if (IsNumberInteresting(number, awesomePhrases)) return 2;
      else if(IsNumberInteresting(number + 1, awesomePhrases) || IsNumberInteresting(number + 2, awesomePhrases)) return 1;
      return 0;
    }

    public static bool IsNumberInteresting(int number, List<int> awesomePhrases)
    {
        if (number < 100) return false;

        string n = number.ToString();
        string reversed = ReverseString(n);
        int tempno = number;
        var digits = new List<int>();
        while (tempno > 0)
        {
          int digit = tempno % 10;
          digits.Add(digit);
          tempno = tempno / 10;
        }

        digits.Reverse();

        bool sameDigitsOrPalindrome = n == reversed.ToString(); // DOESNT WORK CUS REVERSE DOESNT RETURN A NEW ARRAY, IT MODIFIES THE EXISTING ONE
        bool trailingZeroes = true;

        for (var i = 1; i < digits.Count; i++)
        {
          if (digits[i] != 0) 
          {
            trailingZeroes = false;
            break;
          }
        }

        bool matchesPhrase = awesomePhrases.Any(p => number == p);

        bool isDescending = true;
        for(var i = 0; i < digits.Count - 1; i++)
        {
          if (digits[i] < digits[i+1] || digits[i] - digits[i+1] != 1) 
          {
            isDescending = false;
            break;
          }
        }
      
        bool isAscending = true;
        for(var i = 0; i < digits.Count - 1; i++)
        {
          if (digits[i] >= digits[i+1] || digits[i+1] - digits[i] != 1) 
          {
            if (i == digits.Count - 2  && digits[i+1] == 0 && digits[i] == 9) continue;
            isAscending = false;
            break;
          }
        }

        return (sameDigitsOrPalindrome || trailingZeroes || isAscending || isDescending || matchesPhrase);
    } 

    static string ReverseString(string input)
    {
        var inputArray = input.ToCharArray();
        Array.Reverse(inputArray);
        return new string(inputArray);
    }
}

// https://www.codewars.com/kata/52c4dd683bfd3b434c000292