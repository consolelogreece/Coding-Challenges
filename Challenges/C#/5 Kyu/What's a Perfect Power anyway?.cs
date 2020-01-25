using System;

public class PerfectPower
{
    public static (int, int)? IsPerfectPower(int n)
    {
        if(n < 2) return null;

        var curRoot = 2;
        
        while(true)
        {
            var x = (decimal)Math.Pow(n, (1.0 / curRoot));

            var isInteger = x % 1 == 0;

            if (isInteger) return ((int)x, (int)curRoot);
            else if(x < 2) return null;;
            
            curRoot++;
        }
    }
}

// https://www.codewars.com/kata/54d4c8b08776e4ad92000835