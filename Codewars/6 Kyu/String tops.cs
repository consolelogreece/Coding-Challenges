public static class Kata
{
    public static string Tops(string msg)
    {

        //Factor to add to index. 
        //next occurance is 5 spaces away. This add factor increases by 4 everytime. Thus, occurances are at index 1, 6, 15, etc...
        int ftr = 5;

        int i = 1;

        var output = new StringBuilder();

        while (i < msg.Length)
        {
            output.Insert(0, msg[i]);
            i += ftr;
            ftr += 4;
        }

        return output.ToString();
    }
}

//https://www.codewars.com/kata/59b7571bbf10a48c75000070