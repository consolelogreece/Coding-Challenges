using System;

public class Kata
{
  public static long StairsIn20(int[][] stairs)
  {
    int total = 0;
    foreach(var arr in stairs)
    {
      foreach(var n in arr)
      {
        total += n;
      }
    }
    
    return total * 20;
  }
}

// https://www.codewars.com/kata/56fc55cd1f5a93d68a001d4e