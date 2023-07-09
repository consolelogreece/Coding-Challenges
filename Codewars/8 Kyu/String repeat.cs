using System.Text;

namespace Solution
{
  public static class Program
  {
    public static string repeatStr(int n, string s)
    {
      var sb = new StringBuilder(); 
      
      for(int i = 0; i < n; i++)
      {
        sb.Append(s);
      }
      
      return sb.ToString();
    }
  }
}

// https://www.codewars.com/kata/57a0e5c372292dd76d000d7e