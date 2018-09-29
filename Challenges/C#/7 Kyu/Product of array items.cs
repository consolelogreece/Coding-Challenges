namespace Kata
{
    using System;
    using System.Linq;
    public class ArrayMath
    {
        public static int Product(int[] values)
        {
            return values.Aggregate(1, (a, v) => a * v);
        }
    }
}

//https://www.codewars.com/kata/product-of-array-items/train/csharp