using System;

class Kata
{
    public static string Automorphic(int n)
    {
        int nDigits = (int)Math.Floor(Math.Log10(n) + 1);
        int nModuloFactor = (int)Math.Pow(10, nDigits);

        if (n*n % nModuloFactor == n) return "Automorphic";
        return "Not!!";
    }
}

//https://www.codewars.com/kata/5a58d889880385c2f40000aa