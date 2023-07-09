using System;
using System.Linq;

public class Kata
{
  public static int PositiveSum(int[] arr) => arr.Aggregate(0, (a, b) => b > 0 ? a + b : a);
}

//https://www.codewars.com/kata/5715eaedb436cf5606000381