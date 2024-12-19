

using System.Collections.Immutable;

class Result
{

    /*
     * Complete the 'migratoryBirds' function below.
     *
     * The function is expected to return an INTEGER.
     * The function accepts INTEGER_ARRAY arr as parameter.
     */

    public static int migratoryBirds(List<int> arr)
    {
        int result = 0;
        int max = 0;
        HashSet<int> visited = new HashSet<int>();
        Dictionary<int,int> keyValuePairs = new Dictionary<int,int>();

        foreach (int i in arr)
        {
            if (!visited.Contains(i))
            {
                int count = arr.Count(x => x == i);

                if (count > 1 && count > max)
                {
                    keyValuePairs.Add(i, count);
                    max = count;
                    result = i;
                }
                if (count == max)
                {
                    int value = keyValuePairs.FirstOrDefault(x => x.Value == count).Key;
                    result = Math.Min(i, value);
                }
                visited.Add(i);
            }
        }

        return result;
    }

class Solution
{
    public static void Main(string[] args)
    {
            migratoryBirds(new List<int>() { 3, 1, 1, 2, 4, 1, 1, 2, 1, 4, 1, 2, 4, 2, 2, 2, 5, 1, 3, 1, 2, 2, 1, 1, 2, 4, 2, 2, 2, 2, 1, 1, 2, 5, 2, 1, 1, 1, 2, 1, 2, 1, 3, 1, 1, 2, 1, 5, 1, 4,
            1, 1, 1, 3, 5, 2, 1, 1, 4, 2, 4, 2, 2, 2, 1, 1, 3, 2, 2, 1, 3, 5, 4, 2, 2, 4, 4, 5, 2, 2, 2, 3, 1, 2, 1, 2, 3, 2, 2, 1, 1, 2, 5, 2, 2, 1, 1, 1,
            2, 1, 1, 1, 1, 2, 1, 2, 1, 2, 2, 5, 1, 4, 1, 2, 2, 2, 2, 1, 1, 2, 2, 2, 3, 2, 2, 2, 2, 2, 2, 2, 3, 1, 1, 5, 2, 1, 2, 1, 2, 4, 2, 2, 1, 2, 1, 2,});
    }
}

}

