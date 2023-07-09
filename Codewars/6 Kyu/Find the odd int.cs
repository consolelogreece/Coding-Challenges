using System;
namespace Solution
{
  class Kata
    {
    public static int find_it(int[] seq) 
      {
      int result = 0;
      foreach (var i in seq) result ^= i;
      return result;
      }
    }    
}

//https://www.codewars.com/kata/54da5a58ea159efa38000836