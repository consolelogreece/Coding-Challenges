using System;

public static class Kata
{
  public static string[] Capitalize(string s)
  {
    string s1, s2;
    s1 = s2 = "";
    
    for(int i = 0; i < s.Length; i++)
    {
      if (i % 2 == 0)
      {
        s1 += Char.ToUpper(s[i]);
        s2 += Char.ToLower(s[i]);
      }
      else
      {
        s2 += Char.ToUpper(s[i]);
        s1 += Char.ToLower(s[i]);
      }
    }
    
    return new string[]{s1, s2};
  }
}

// https://www.codewars.com/kata/59cfc000aeb2844d16000075