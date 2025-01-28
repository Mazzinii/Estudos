using System.Reflection;

class Result
{

    /*
     * Complete the 'caesarCipher' function below.
     *
     * The function is expected to return a STRING.
     * The function accepts following parameters:
     *  1. STRING s
     *  2. INTEGER k
     */

    public static string caesarCipher(string s, int k)
    {
        string result = string.Empty;
        string letters = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ";

        foreach (char c in s)
        {
            if (!letters.Contains(c)) result += c;
            else
            {
                int index = letters.IndexOf(c) + k;
                while (index > 26) index = index % 26;
                if (char.IsUpper(c)) result += char.ToUpper(letters[index]);
                else result += letters[index];

            }
        }
        return result;
    }

    class Solution
    {
        public static void Main(string[] args)
        {
            caesarCipher("!m-rB`-oN!.W`cLAcVbN/CqSoolII!SImji.!w/`Xu`uZa1TWPRq`uRBtok`xPT`lL-zPTc.BSRIhu..-!.!tcl!-U", 62);
        }
    }

}

/*
         string result = s;
        string letters = "abcdefghijklmnopqrstuvwxyz";
        HashSet<char> collection = new HashSet<char>(); ;

        foreach(char c in s)
        {
            if (!collection.Contains(c))
            {
                if(char.IsLetter(c))
                {
                    int index = letters.IndexOf(char.ToLower(c)) + k;
                    while (index > 25) index += -25;
                    if (char.IsUpper(c)) result = result.Replace(c, char.ToUpper(letters[index]));
                    else result = result.Replace(c, letters[index]);
                    collection.Add(c);
                }
            }


                
        }
        return result;
*/

