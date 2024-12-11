class Result
{

    /*
     * Complete the 'matchingStrings' function below.
     *
     * The function is expected to return an INTEGER_ARRAY.
     * The function accepts following parameters:
     *  1. STRING_ARRAY strings
     *  2. STRING_ARRAY queries
     */

    public static List<int> matchingStrings(List<string> strings, List<string> queries)
    {
        List<int> result = new List<int>();

        foreach (string s in queries) 
        {
            if (strings.Contains(s))
            {
                result.Add(strings.Count(x => x == s));
            }
            else result.Add(0);
        }

        return result;

    }

class Solution
{
    public static void Main(string[] args)
    {
            matchingStrings(["ab", "ab", "abc"], ["ab", "abc", "bc"]);
    }
}

}

