class Result
{

    /*
     * Complete the 'anagram' function below.
     *
     * The function is expected to return an INTEGER.
     * The function accepts STRING s as parameter.
     */

    public static int anagram(string s)
    {
        int split = s.Length;
        string arr1 = s.Substring(0, split / 2);
        string arr2 = s.Substring(split / 2, split - split / 2);
        int result = 0;

        for(int i = 0; i < arr1.Length; i++)
        {
            if (!arr2.Contains(arr1[i]))
            {
                result++;
            }
        }

        if (result == 0) return -1;

        return result;

    }
class Solution
{
    public static void Main(string[] args)
    {
            anagram("abccde");
    }
}

}
