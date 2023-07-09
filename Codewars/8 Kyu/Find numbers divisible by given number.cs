using System.Linq;

public class Kata
{
  public static int[] DivisibleBy(int[] numbers, int divisor) => numbers.Where(n => n % divisor == 0).ToArray();
}