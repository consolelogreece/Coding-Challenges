using System;
using System.Text;

public static class Decoder
{
    public static string Decode(string p_what)
    { 
      Console.WriteLine(p_what);
        // Char string was found by inputting a long string of a single character a few times, changing the character each time.
        // It became obvious that the same string was used in a cyclical way.
        string charstring =  "bdhpF,82QsLirJejtNmzZKgnB3SwTyXG ?.6YIcflxVC5WE94UA1OoD70MkvRuPqHa";
        int len = charstring.Length;
        int i = 0;
      
        // To understand what is happening, I first try to replicate the encode method:
        string encoded = "";
    
        foreach (char w in p_what) {
          i++;
          // Just insert anything not in the charstring as is
          if (charstring.IndexOf(w) == -1)
          {
            encoded += w;
            continue;
          }
          var predictedIndex = charstring.IndexOf(w) + (i % len);
          var predictedChar = charstring[predictedIndex % len];
          encoded += predictedChar;
        }
      
        Console.WriteLine("Encoding match: " + (encoded == Encoder.Encode(p_what) ? "Yes" : "No"));
      
        // Now to decode, just reverse the process:
        string decoded = "";
        i = 0;
      
        foreach (char w in p_what) {
          i++;
          if (charstring.IndexOf(w) == -1)
          {
            decoded += w;
            continue;
          }
          var predictedIndex = charstring.IndexOf(w) - (i % len);
          if (predictedIndex < 0) predictedIndex += len;
          var predictedChar = charstring[predictedIndex % len];
          decoded += predictedChar;
        }

        return decoded;
    }
}

// https://www.codewars.com/kata/52cf02cd825aef67070008fa