public static class Kata
{
  public static int[] ReverseSeq(int n)
  {
    var seq = new int[n];
    
    for(int i = 0; i < n; i++) seq[i] = n - i;
    
    return seq;
  }
}

// https://www.codewars.com/kata/5a00e05cc374cb34d100000d