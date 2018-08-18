using System;

public class Kata
{
    public static bool CheckIfFlush(string[] cards)
    {
        char suit = cards[0][cards[0].Length - 1];
        foreach (string c in cards) if (c[c.Length - 1] != suit) return false;
        return true;
    }
}

//https://www.codewars.com/kata/5acbc3b3481ebb23a400007d