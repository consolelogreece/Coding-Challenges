using System.Linq;
using System;

public class Kata
{
   public static int SumMix(object[] x) => x.Aggregate(0, (t, n) => t + Convert.ToInt32(n));
}

// https://www.codewars.com/kata/57eaeb9578748ff92a000009