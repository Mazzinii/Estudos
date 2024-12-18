class Result
{

    /*
     * Complete the 'twoArrays' function below.
     *
     * The function is expected to return a STRING.
     * The function accepts following parameters:
     *  1. INTEGER k
     *  2. INTEGER_ARRAY A
     *  3. INTEGER_ARRAY B
     */

    public static string twoArrays(int k, List<int> A, List<int> B)
    {
        A.Sort();
        B.Sort();
        B.Reverse();
        string result = "YES";
        int count = 0;

        foreach (int number in A)
        {
            if ((number + B[count]) < k) result = "NO";
            count++;
        }
        return result;
    }

class Solution
{
    public static void Main(string[] args)
    {
            twoArrays(5, [1, 2, 2, 1], [3, 3, 3, 4]);
    }
}

}

