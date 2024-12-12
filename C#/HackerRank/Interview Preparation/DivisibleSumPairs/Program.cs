using System.ComponentModel.Design;

class Result
{

    /*
     * Complete the 'divisibleSumPairs' function below.
     *
     * The function is expected to return an INTEGER.
     * The function accepts following parameters:
     *  1. INTEGER n
     *  2. INTEGER k
     *  3. INTEGER_ARRAY ar
     */

    public static int divisibleSumPairs(int n, int k, List<int> ar)
    {
        int result = 0;

        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                if (i < j && (ar[i] + ar[j]) % k == 0) result++;

            }
        }

        return result;
    }

    public static void Main(string[] args)
    {
        divisibleSumPairs(6, 5, [1, 2, 3, 4, 5, 6]);
    }    
}
