using System.Text;

using System;

namespace Kata
{
    public class PaulCipher
    {
        private static readonly string _alphabet = "\0ABCDEFGHIJKLMNOPQRSTUVWXYZ";

        public static string Encode(string input)
        {
            if (String.IsNullOrEmpty(input)) return "";
            bool foundFirstFlag = false;

            int prevCharVal = 0;

            var retStr = new StringBuilder();

            for (int i = 0; i < input.Length; i++)
            {
                string currChar = input[i].ToString().ToUpper();

                if (!_alphabet.Contains(currChar))
                {
                    retStr.Append(currChar);
                    continue;
                }

                if (!foundFirstFlag)
                {
                    foundFirstFlag = true;
                    prevCharVal = _alphabet.IndexOf(currChar);
                    retStr.Append(currChar);
                }
                else
                {
                    var n = ((_alphabet.IndexOf(currChar) + prevCharVal) % 26);
                    retStr.Append(_alphabet[n]);
                    prevCharVal = _alphabet.IndexOf(currChar);
                }
            }

            return retStr.ToString();
        }

        public static string Decode(string input)
        {
            if (String.IsNullOrEmpty(input)) return "";

            bool foundFirstFlag = false;

            int prevCharVal = 0;

            var retStr = new StringBuilder();

            for (int i = 0; i < input.Length; i++)
            {
                string currChar = input[i].ToString().ToUpper();

                if (!_alphabet.Contains(currChar))
                {
                    retStr.Append(currChar);
                    continue;
                }

                if (!foundFirstFlag)
                {
                    foundFirstFlag = true;
                    prevCharVal = _alphabet.IndexOf(currChar);
                    retStr.Append(currChar);
                }
                else
                {
                    var n = Math.Abs(((26 + _alphabet.IndexOf(currChar) - prevCharVal) % 26));
                    if (n == 0) n = 26;
                    retStr.Append(_alphabet[n]);
                    prevCharVal = _alphabet.IndexOf(_alphabet[n]);
                }
            }

            return retStr.ToString();
        }
    }
}

https://www.codewars.com/kata/57c4ed873189a5bea00007e6