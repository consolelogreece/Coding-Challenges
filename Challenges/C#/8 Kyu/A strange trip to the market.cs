using System;

public static class Kata 
{
  public static bool IsLockNessMonster(string sentence) 
  {
    var normalizedSentence = sentence.ToLower();

    return (normalizedSentence.Contains("tree fiddy") 
    || normalizedSentence.Contains("3.50") 
    || normalizedSentence.Contains("tree fifty"));
  }
}

//https://www.codewars.com/kata/55ccdf1512938ce3ac000056