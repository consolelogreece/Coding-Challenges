public class Kata
{
    public static bool Feast(string beast, string dish) =>
      beast[0] == dish[0] && beast[beast.Length - 1] == dish[dish.Length - 1];
}

//https://www.codewars.com/kata/5aa736a455f906981800360d