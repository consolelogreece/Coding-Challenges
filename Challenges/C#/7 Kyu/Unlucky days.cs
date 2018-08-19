using System;
public class Kata
{
  public static int UnluckyDays(int year)
  {
    int count = 0;
    for (int i = 1; i < 13; i++)
    {
      var d = new DateTime(year,i,13);
      if((int)d.DayOfWeek == 5) count++;
    }
    
    return count;
  }
}

//https://www.codewars.com/kata/56eb0be52caf798c630013c0