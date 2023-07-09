public class Kata
{
  public static int Gcd(int a, int b)
    {
        int smallest, largest;

        if (a > b)
        {
            smallest = b;
            largest = a;
        }
        else
        {
            smallest = a;
            largest = b;
        }

        var m = largest % smallest;

        if (m == 0) return smallest;
        if (m == 1) return 1;
        return Gcd(smallest, m);
    }
}

//https://www.codewars.com/kata/5500d54c2ebe0a8e8a0003fd