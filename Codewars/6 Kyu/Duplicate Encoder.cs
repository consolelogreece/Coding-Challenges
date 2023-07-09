using System.Collections.Generic;
using System; 
public class Kata
{
  public static string DuplicateEncode(string word)
  {
    var charCount = new Dictionary<char, int>();
    var returnString = "";
    
    foreach(char c in word)
    {
      var ch = char.ToLower(c);
      if (!charCount.ContainsKey(ch)) charCount.Add(ch, 1);
      else  charCount[ch]++;
    }  
        
    foreach(char c in word) returnString += (charCount[char.ToLower(c)] > 1) ? ')' : '(';
    
    return returnString;
  }
}

// https://www.codewars.com/kata/54b42f9314d9229fd6000d9c