using System;
using System.Text;

public class Fracts
{
    public static string convertFrac(long[,] lst)
    {
        if (lst == null || lst.Length == 0) return "";
        
        long largestDenomInList = findLargestDenom(lst);

        long lcm = findSmallestCommonDenom(lst, largestDenomInList);

        var retstr = new StringBuilder();

        long factor;

        for (int i = 0; i < lst.GetLength(0); i++)
        {
            factor = lcm / lst[i, 1];
            retstr.Append("(" + (lst[i, 0] * factor) + "," + (lst[i, 1] * factor) + ")");
        }

        Console.WriteLine(retstr.ToString());
        return retstr.ToString();
    }

    public static long findLargestDenom(long[,] lst)
    {
        long largestDenom = lst[0, 1];
        for (int i = 1; i < lst.GetLength(0); i++)
        {
            if (lst[i, 1] > largestDenom) largestDenom = lst[i, 1];
        }
        return largestDenom;
    }

    public static long findSmallestCommonDenom(long[,] lst, long largestDenomInList)
    {
        long lcm = largestDenomInList;
        long inc = largestDenomInList;
        bool breakFlag = false;
        bool foundLCM = false;

        // finds smallest common denom.
        while (!foundLCM)
        {
            breakFlag = false;
            for (int i = 0; i < lst.GetLength(0); i++)
            {
                if (inc % lst[i, 1] != 0) { breakFlag = true; break; }
            }
            if (!breakFlag)
            {
                lcm = inc;
                foundLCM = true;
            }
            else
            {
                inc += largestDenomInList;
            }
        }
        return lcm;
    }
}

//https://www.codewars.com/kata/54d7660d2daf68c619000d95