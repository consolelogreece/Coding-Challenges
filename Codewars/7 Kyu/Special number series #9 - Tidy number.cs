using System.Linq;

class Kata
{
    public static bool TidyNumber(int n)
    {
        int[] nArr = n.ToString().Select(t => int.Parse(t.ToString())).ToArray();
        
        for (int i = 1; i < nArr.Length; i++) if (nArr[i] < nArr[i - 1]) return false;
          
        return true;
    }
}

//https://www.codewars.com/kata/5a87449ab1710171300000fd