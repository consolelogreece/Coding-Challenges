using System.Linq;

class AreTheySame
{
   public static bool comp(int[] a, int[] b)
    {
        if (a == null || b == null || a.Length != b.Length) return false;

        var listedB = b.ToList();

        for(int i = 0; i < a.Length; i++)
        {
          var index = listedB.FindIndex(x => x == (a[i] * a[i]));

          if (index == -1) return false;

          listedB.RemoveAt(index);
        }

        return true;
    }   
}

//https://www.codewars.com/kata/550498447451fbbd7600041c