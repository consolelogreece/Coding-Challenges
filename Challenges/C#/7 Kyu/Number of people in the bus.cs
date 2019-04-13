using System.Linq;
using System;
using System.Collections.Generic;

public class Kata
{
    public static int Number(List<int[]> peopleListInOut) => peopleListInOut.Aggregate(0, (a, c) => a += (c[0] - c[1])); 
}

// https://www.codewars.com/kata/5648b12ce68d9daa6b000099