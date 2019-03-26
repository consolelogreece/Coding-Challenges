using System;
using System.Collections.Generic;
using System.Linq;

class MaxSumDigits
{
    static void Main(string[] args)
    {
        var x = MaxSumDig(2000, 3);
    }

    public static long[] MaxSumDig(long nmax, int maxsm)
    {
        var validNumbers = new List<long>();

        for (long i = 1000; i <= nmax; i++)
        {
            if (SumDigitsLT(i, maxsm))
            {
                validNumbers.Add(i);
            }
        }
        return new long[] { validNumbers.Count, FindClosestToMean(validNumbers), validNumbers.Sum() };
    }

    private static bool SumDigitsLT(long num, int maxsm)
    {
        int sum = 0;
        while (num != 0)
        {
            sum += (int)num % 10;

            if (sum > maxsm) return false;

            num /= 10;
        }

        return true;
    }

    private static long FindClosestToMean(List<long> numbers)
    {
        var avg = numbers.Average();

        return numbers.OrderBy(x => Math.Abs(avg - x)).First();
    }
}

//https://www.codewars.com/kata/55f5efd21ad2b48895000040