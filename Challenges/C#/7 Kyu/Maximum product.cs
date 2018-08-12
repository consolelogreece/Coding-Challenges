public class Kata
{
    public static int AdjacentElementsProduct(int[] array)
    {
        int currHighest = array[0] * array[1];
        
        for(int i = 1; i < array.Length - 1 ; i++) {
          if ((array[i] * array[i+1]) > currHighest) currHighest = array[i] * array[i+1];
        }
        
        return currHighest;
    }
}

//https://www.codewars.com/kata/5a4138acf28b82aa43000117