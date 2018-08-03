using System;
public class ASum {
	
	public static long findNb(long m) {
		int counter = 1;
    
    while (m > 0) {
      m -= (long)Math.Pow(counter, 3);
      counter++;
    }
    if (m == 0) {return counter - 1;}
    return -1;
 
	}
	
}

//https://www.codewars.com/kata/5592e3bd57b64d00f3000047