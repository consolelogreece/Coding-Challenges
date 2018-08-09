using System;
using System.Text;

public static class Kata
{
  public static string AlphabetPosition(string text)
  {
  
    StringBuilder result = new StringBuilder();
    
    text = text.ToUpper();
    
    foreach(char c in text)
    {
      if (Char.IsLetter(c)) {
        result.Append(((int)c - 64).ToString());
        result.Append(" ");
      }
    }

    
    return result.ToString().Trim();
    
  }
}

//https://www.codewars.com/kata/546f922b54af40e1e90001da