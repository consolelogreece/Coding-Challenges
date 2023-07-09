using System;
using System.Text;

public class Kata
{
    public static string Grille(string message, int code)
    {
        int msgLen = message.Length;

        string codeBinary = Convert.ToString(code, 2).PadLeft(msgLen, '0');

        int offset = codeBinary.Length - msgLen;
        
        var retstr = new StringBuilder();

        for (int i = 0; i < message.Length; i++)
            if (codeBinary[i + offset] == '1') retstr.Append(message[i]);

        return retstr.ToString();
    }
}

//https://www.codewars.com/kata/595b3f0ad26b2d817400002a