class Result
{

    /*
     * Complete the 'sockMerchant' function below.
     *
     * The function is expected to return an INTEGER.
     * The function accepts following parameters:
     *  1. INTEGER n
     *  2. INTEGER_ARRAY ar
     */

    public static int sockMerchant(int n, List<int> ar)
    {
        int result = 0;
        HashSet<int> visited = new HashSet<int>();

        foreach(int i in ar)
        {
            if (!visited.Contains(i))
            {
                int count = ar.Count(x => x == i);
                if (count == 2) result++;
                if (count > 2 && count % 2 == 0) result += count / 2;
                else result += (count - 1) / 2;
                visited.Add(i);
            }
        }

        return result;
    }

class Solution
{
    public static void Main(string[] args)
    {
            sockMerchant(7, [1, 2, 1, 2, 1, 3, 2]);
    }
}

}

