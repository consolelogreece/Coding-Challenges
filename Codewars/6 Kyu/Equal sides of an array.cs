using System.Linq;

public class Kata
{
  public static int FindEvenIndex(int[] arr)
  {
    int accLeft = 0;
    int accRight = arr.Sum();
    
    for (int i = 0; i < arr.Length; i++) {
      accRight -= arr[i];
      if (accLeft == accRight) return i;
      accLeft += arr[i];
    }
    
    return -1;
  }
}

//https://www.codewars.com/kata/5679aa472b8f57fb8c000047