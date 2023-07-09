using System.Linq;
using System;
using System.Collections.Generic;

public class Kata {
  public static readonly Dictionary<string, char> charMap = new Dictionary<string, char>()
      {
        {"/\\", 'a'},
        {"]3", 'b'},
        {"(", 'c'},
        {"|)", 'd'},
        {"[-", 'e'},
        {"/=", 'f'},
        {"(_,", 'g'},
        {"|-|", 'h'},
        {"|", 'i'},
        {"_T", 'j'},
        {"/<", 'k'},
        {"|_", 'l'},
        {"|\\/|", 'm'},
        {"|\\|", 'n'},
        {"()", 'o'},
        {"|^", 'p'},
        {"()_", 'q'},
        {"/?", 'r'},
        {"_\\~", 's'},
        {"~|~", 't'},
        {"|_|", 'u'},
        {"\\/", 'v'},
        {"\\/\\/", 'w'},
        {"><", 'x'},
        {"`/", 'y'},
        {"~/_", 'z'},
        {"__", ' '}
      };
      
  public static string Decode(string m) {
      return new String(m.Split(m[0]).Where(w => w != "").Reverse().Select(c => charMap[c]).ToArray());
  }
}

// https://www.codewars.com/kata/598980a41e55117d93000015