class Result
{

    /*
     * Complete the 'dynamicArray' function below.
     *
     * The function is expected to return an INTEGER_ARRAY.
     * The function accepts following parameters:
     *  1. INTEGER n
     *  2. 2D_INTEGER_ARRAY queries
     */

    public static List<int> dynamicArray(int n, List<List<int>> queries)
    {
        int lastAnswer = 0;
        List<List<int>> arrays = new List<List<int>>();
        List<int> result = new List<int>();


        for(int i = 0; i < n; i++)
        {
            List<int> array = new List<int>();
            arrays.Add(array);
        }

        for(int i = 0; i < queries.Count;i++)
        {
            int querie = queries[i][0];
            int array = queries[i][1];
            int number = queries[i][2];

            if (querie == 1) arrays[(array + lastAnswer) % n].Add(number);
            else
            {
                List<int> seq = arrays[(array + lastAnswer) % n];
                lastAnswer = seq[array % seq.Count];
                result.Add(lastAnswer);
            }
        }

        return result;

    }

class Solution
{
    public static void Main(string[] args)
    {

            dynamicArray(2, [[1, 2], [2, 3]]);
    }
}

}
