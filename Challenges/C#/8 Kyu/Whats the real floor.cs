using System;

public static class Kata
{
  public static int GetRealFloor(int n)
  {
    if (n > 12) n-=1;
    if (n >= 1) n -= 1;
    
    return n; 
  }
}

// https://www.codewars.com/kata/574b3b1599d8f897470018f6