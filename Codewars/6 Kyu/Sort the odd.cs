using System.Collections.Generic;
using System.Linq;

public class Kata
{
  public static int[] SortArray(int[] array)
  {      
    var numbers = new List<int>();
    var indexes = new List<int>();
    
    for(int i = 0; i < array.Length; i++)
    {
      if (array[i] % 2 != 0)
      {
        numbers.Add(array[i]);
        indexes.Add(i);
      }
    }
    
    numbers.Sort();
    
    for(int i = 0; i < numbers.Count; i++) array[indexes[i]] = numbers[i];    
    
    return array;
  }
}

// https://www.codewars.com/kata/578aa45ee9fd15ff4600090d