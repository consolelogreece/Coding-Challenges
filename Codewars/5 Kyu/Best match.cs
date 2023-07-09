namespace myjinxin
{
    using System;
    
    public class Kata
    {
        public int BestMatch(int[] goals1, int[] goals2){
          
          int currBestIndex = 0;
          int currBestZA = goals2[0];
          int difference = Math.Abs(goals1[0] - goals2[0]);
          
          for (int i = 1; i < goals1.Length; i++) 
          {
            int dif = Math.Abs(goals1[i] - goals2[i]);
            if ((dif < difference) || (dif == difference && goals2[i] > currBestZA))
             {
               currBestIndex = i;
               currBestZA = goals2[i];
               difference = dif;
             } 
          }
          return currBestIndex; 
        }
    }
}

//https://www.codewars.com/kata/58b38256e51f1c2af0000081