using System;

public static class Kata
{
  public static int MakeNegative(int number)
  {
    if (number <= 0) {
      return number;
    }     
    return number * -1;  
  }
}

//https://www.codewars.com/kata/55685cd7ad70877c23000102