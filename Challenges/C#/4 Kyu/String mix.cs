using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System;
using System.Text;

public class Mixing
{
    protected static string removeAllNonNumericAndNonLowercase(string input)
    {
        Regex rgx = new Regex("[^a-z]");
        return rgx.Replace(input, "");
    }

    /// <summary>
    /// Generates maps used for building return string.
    /// </summary>
    /// <param name="formattedStr1">s1 with all non numeric lowercase chars removed</param>
    /// <param name="formattedStr2">s2 with all non numeric lowercase chars removed</param>
    /// <param name="mapDict">
    ///     map of char occurences, in dictionary form, in form {char, int[nOccurances, stringWithMostOccurances]} 
    /// </param>
    /// <param name="orderedMap">
    ///     map of chars in list form, ordered by occurances (descending order), 
    ///     then by which str it occured in, then by alphabetical order
    /// </param>
    public static void GenerateMap(string formattedStr1, string formattedStr2, out Dictionary<char, int[]> mapDict, out IOrderedEnumerable<KeyValuePair<char, int[]>> orderedMap)
    {
        var s1Constituants = formattedStr1.GroupBy(c => c).Select(c => new { Char = c.Key, Count = c.Count() });
        var s2Constituants = formattedStr2.GroupBy(c => c).Select(c => new { Char = c.Key, Count = c.Count() });

        Dictionary<char, int[]> map = new Dictionary<char, int[]>();

        foreach (var cons in s1Constituants)
            map.Add(cons.Char, new int[] { cons.Count, 1 });

        foreach (var cons in s2Constituants)
        {
            char key = cons.Char;
            int s2Count = cons.Count;
            if (map.ContainsKey(key))
            {
                int s1Count = map[key][0];
                if (s2Count > s1Count)
                    map[key] = new int[] { s2Count, 2 };

                else if (s2Count == s1Count)
                    map[key] = new int[] { s2Count, Int32.MaxValue };

            }
            else
                map.Add(key, new int[] { s2Count, 2 });
        }
        orderedMap = map.OrderByDescending(x => x.Value[0]).ThenBy(x => x.Value[1]).ThenBy(x => x.Key);
        mapDict = map;
    }

    public static string Mix(string s1, string s2)
    {
        string formattedStr1 = removeAllNonNumericAndNonLowercase(s1);
        string formattedStr2 = removeAllNonNumericAndNonLowercase(s2);

        Dictionary<char, int[]> mapDict;
        IOrderedEnumerable<KeyValuePair<char, int[]>> orderedMap;

        GenerateMap(formattedStr1, formattedStr2, out mapDict, out orderedMap);

        StringBuilder result = new StringBuilder();

        foreach (KeyValuePair<char, int[]> el in orderedMap)
        {
            if (mapDict[el.Key][0] < 2) continue;

            string s1ors2 = ((mapDict[el.Key][1] == Int32.MaxValue) ? "=" : mapDict[el.Key][1].ToString()) + ":";

            result.Append(s1ors2);

            for (int i = 0; i < mapDict[el.Key][0]; i++)
            {
                result.Append(el.Key);
            }
            result.Append("/");
        }
        if (result.Length > 0) result.Length--;
        return result.ToString();
    }
}

//https://www.codewars.com/kata/5629db57620258aa9d000014