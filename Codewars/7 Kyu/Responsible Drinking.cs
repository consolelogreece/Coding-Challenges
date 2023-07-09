using System;
using System.Linq;

public class Drinkin
{
    public string hydrate(string drinkString)
    {
        var sum = 0;
        var val = 0;
        for (int i = 0; i < drinkString.Length; i++)
        {
            if (int.TryParse(drinkString[i].ToString(),out val))
                sum += val;
        }
        
        return sum + (sum == 1 ? " glass" : " glasses") + " of water";
    }
}

// https://www.codewars.com/kata/5aee86c5783bb432cd000018
