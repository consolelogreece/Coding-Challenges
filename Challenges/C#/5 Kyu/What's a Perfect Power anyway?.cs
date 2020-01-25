public class PerfectPower
{
    public static (int, int)? IsPerfectPower(int n)
    {
        if(n < 2) return null;

        var curRoot = 2;
        
        while(true)
        {
            var x = nroot(n, curRoot);

            var isInteger = x % 1 == 0;

            if (isInteger) return ((int)x, (int)curRoot);
            else if(x < 2) return null;
            
            curRoot++;
        }
    }

    private static decimal nroot(double num, double root)
    {
        return (decimal)Math.Pow(num, (1.0 / root));
    }
}

// https://www.codewars.com/kata/54d4c8b08776e4ad92000835