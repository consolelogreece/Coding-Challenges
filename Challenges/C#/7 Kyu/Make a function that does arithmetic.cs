using System;

public class Kata 
{
  public static double Arithmetic(double a, double b, string op) 
  {
    switch(op){
      case "add":
        return a + b;
      
      case "subtract":
        return a - b;
      
      case "multiply":
        return a * b;
      
      case "divide":
        return a / b;
        
        default: return 0;
      
    }
  }
}

//https://www.codewars.com/kata/583f158ea20cfcbeb400000a