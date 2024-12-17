using System.Text.RegularExpressions;

class Result
{

    /*
     * Complete the 'marsExploration' function below.
     *
     * The function is expected to return an INTEGER.
     * The function accepts STRING s as parameter.
     */

    public static int marsExploration(string s)
    {
        int result = 0;

        for(int i = 0; i < s.Count(); i += 3)
        {
            string word = s.Substring(i, Math.Min(3, s.Length - i));

            if (word.Length > 0 && word[0] != 'S') result++;
            if (word.Length > 1 && word[1] != 'O') result++;
            if (word.Length > 2 && word[2] != 'S') result++;
        }

        return result;
        
    }
class Solution
{
    public static void Main(string[] args)
    {
            marsExploration("SOSTOT");
    }
}

}

