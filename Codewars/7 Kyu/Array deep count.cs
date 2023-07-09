public class Kata
{
    public static int DeepCount(object a)
    {
        int count = 0;

        DeepCountHelper(a as object[], ref count);

        return count;
    }

    public static void DeepCountHelper(object[] a, ref int count)
    {
        foreach (object el in a)
        {
            count++;
            if (el.GetType().IsArray)
            {
                DeepCountHelper((object[])el, ref count);
            }
        }
    }
}

//https://www.codewars.com/kata/596f72bbe7cd7296d1000029