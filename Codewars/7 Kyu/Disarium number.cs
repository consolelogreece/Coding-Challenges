using System.Collections.Generic;
using System;

class Kata
{
    public static string DisariumNumber(int number)
    {
        int[] numbers = genArrayOfDigits(number);

        double sum = 0;

        for (int i = 0; i < numbers.Length; i++)
        {
            sum += Math.Pow(numbers[i], i + 1);
        }

        return (sum == (double)number) ? "Disarium !!" : "Not !!";
    }

    public static int[] genArrayOfDigits(int number)
    {
        var numbers = new Stack<int>();

        for (; number > 0; number /= 10)
            numbers.Push(number % 10);

        return numbers.ToArray();
    }
}

//https://www.codewars.com/kata/5a53a17bfd56cb9c14000003