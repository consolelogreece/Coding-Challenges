using System;

class Bud
{
    public static string Buddy(long start, long limit)
    {
        long currNo = start;

        for(; currNo <= limit; currNo++)
        {
            long sumDiv = getSumDivisors(currNo) - 1;
            if ((getSumDivisors(sumDiv) - 1) == currNo && currNo < sumDiv) return ($"({currNo} {sumDiv})");
        }
        return "Nothing";
    }

    public static long getSumDivisors(long n)
    {
        long result = 0;
        for (long i = 2; i <= Math.Sqrt(n); i++)
        {
            if (n % i == 0)
            {
                if (i == (n / i)) result += i;
                else result += (i + n / i);
            }
        }
        return result + 1;
    }
}

//https://www.codewars.com/kata/59ccf051dcc4050f7800008f