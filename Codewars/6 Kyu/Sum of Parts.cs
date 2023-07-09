using System;
using System.Linq;

class SumParts
{
    public static int[] PartsSums(int[] ls)
    {
        int[] stuff = new int[ls.Length + 1];

        var sum = ls.Sum();

        for(int i = 0; i < ls.Length; i++)
        { 
            stuff[i] = sum;
            sum -= ls[i];
        }
    
        return stuff;
    }
}

//https://www.codewars.com/kata/5ce399e0047a45001c853c2b