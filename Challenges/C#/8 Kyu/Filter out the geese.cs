using System.Collections.Generic;
using System.Linq;

public static class Filter
{
  public static IEnumerable<string> GooseFilter(IEnumerable<string> birds)
  {
    // return IEnumerable of string containing all of the strings in the input collection, except those that match strings in geese
    string[] geese = new string[] { "African", "Roman Tufted", "Toulouse", "Pilgrim", "Steinbacher" };

    return birds.Where(b => !geese.Contains(b));
  }
}

//https://www.codewars.com/kata/57ee4a67108d3fd9eb0000e7