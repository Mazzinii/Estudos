class Result
{

    /*
     * Complete the 'minimumAbsoluteDifference' function below.
     *
     * The function is expected to return an INTEGER.
     * The function accepts INTEGER_ARRAY arr as parameter.
     */

    public static int minimumAbsoluteDifference(List<int> arr)
    {
        arr.Sort();

        long result = 0;
        long min = int.MaxValue;

        for(int i = 0; i < arr.Count - 1; i++)
        {
            result = Math.Abs(arr[i] - arr[i + 1]);

            if(result < min)
            {
                min = result;
            }
        }
        return min;
    }

    public static void Main(string[] args)
    {
        minimumAbsoluteDifference([1,-3,71,68,17]);
    }

}
