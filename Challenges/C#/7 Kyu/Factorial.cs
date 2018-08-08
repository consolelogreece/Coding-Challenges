using System;

public static class Kata
{
  public static int Factorial(int n)
  {
    if (n > 12 || n < 0) throw new System.ArgumentOutOfRangeException();
    
    int sum = 1;

    for (var i = 1; i <= n; i++) sum *= i;

    return sum;
  }
}

//https://www.codewars.com/kata/54ff0d1f355cfd20e60001fc



