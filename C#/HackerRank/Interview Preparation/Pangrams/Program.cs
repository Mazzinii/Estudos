

class Result
{

    /*
     * Complete the 'pangrams' function below.
     *
     * The function is expected to return a STRING.
     * The function accepts STRING s as parameter.
     */

    public static string pangrams(string s)
    {
        SortedSet<char> result = new SortedSet<char>();

        string word = Regex.Replace(s.ToLower(), @"[^a-z]", "");

        foreach (char ch in word)
        {
            result.Add(ch);
        }

        return result.Count == 26 ? "pangram" : "no pangram";

    }
class Solution
{
    public static void Main(string[] args)
    {

    }

}

}