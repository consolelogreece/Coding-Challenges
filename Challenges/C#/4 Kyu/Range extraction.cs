using System;
public class RangeExtraction
  {
      public static string Extract(int[] args)
      {
          var output = "";
        
          for(int i = 0; i < args.Length; i++)
          {
            var substr = "";
            if ((i < args.Length - 2 ) && (Math.Abs(args[i] - args[i+1]) == 1) && (Math.Abs(args[i+1] - args[i+2]) == 1))
            {
                substr += args[i];
                substr += "-";
                while((i < args.Length - 1) && (args[i] - (args[i+1]-1) == 0)) i++;
                substr += args[i];
            }
            else {
              substr = substr += args[i];
            }
            
            output+= substr + ",";
          }   

          return output.Substring(0, output.Length - 1);
      }
  }

  // https://www.codewars.com/kata/51ba717bb08c1cd60f00002f