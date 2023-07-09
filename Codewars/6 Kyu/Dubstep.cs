using System;
using System.Linq;
using System.Text.RegularExpressions;

public class Dubstep
    {
        public static string SongDecoder(string input)
        { 
            string retstr = input.Replace("WUB", " ").Trim();
            RegexOptions options = RegexOptions.None;
            Regex regex = new Regex("[ ]{2,}", options);     
            return regex.Replace(retstr, " ");
         
           
        }
    }

//https://www.codewars.com/kata/551dc350bf4e526099000ae5