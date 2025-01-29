using System.Diagnostics;

class Result
{

    /*
     * Complete the 'maxMin' function below.
     *
     * The function is expected to return an INTEGER.
     * The function accepts following parameters:
     *  1. INTEGER k
     *  2. INTEGER_ARRAY arr
     */

    public static int maxMin(int k, List<int> arr)
    {
        Stopwatch stopWatch = new Stopwatch();
        stopWatch.Start();

        arr.Sort();
        int calc = 0;
        int min = int.MaxValue;

        for(int i = 0; i <= arr.Count - k; i++)
        {
            calc = arr[i + k - 1] - arr[i];

            if (calc < min) min = calc;
           
        }

        stopWatch.Stop();

        return min;

    }

class Solution
{
    public static void Main(string[] args)
    {
            maxMin(3, [10, 100, 300, 200,1000,20,30]);
    }
}

}
