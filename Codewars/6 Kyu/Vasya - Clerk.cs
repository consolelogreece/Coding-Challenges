using System;

public class Line
    {
        public static string Tickets(int[] peopleInLine)
        { 
            int n25 = 0;
            int n50 = 0;
            
            foreach(int person in peopleInLine) {
              switch (person) {
                case 25:
                  n25++;
                  break;
                case 50:
                  if (n25 == 0) return "NO";
                  n25--;
                  n50++;
                  break;
                case 100:
                  if (n50 != 0 && n25 != 0) {
                    n50--;
                    n25--;
                  } else if (n25 >= 3) {
                    n25 -= 3;
                  } else {
                    return "NO";
                  }

                  break;
              }
            }
           
            return "YES";
        }
    }

//https://www.codewars.com/kata/555615a77ebc7c2c8a0000b8