using System;

public class Kata
{
  public static string Problem(String a)
  {
      double b;
      if (Double.TryParse(a, out b)) return ((b * 50) + 6).ToString();
      return "Error";
  }
}

//https://www.codewars.com/kata/super-duper-easy/train/csharp