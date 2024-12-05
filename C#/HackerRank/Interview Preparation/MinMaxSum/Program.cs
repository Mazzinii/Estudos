using System.Numerics;
class Result
{

    /*
     * Complete the 'miniMaxSum' function below.
     *
     * The function accepts INTEGER_ARRAY arr as parameter.
     */

    public static void miniMaxSum(List<int> arr)
    {
        
        arr.Sort();
        long min = (long)arr[0] + arr[1] + arr[2] + arr[3];
        long max = (long)arr[1]+ arr[2] + arr[3] + arr[4];
        

        Console.WriteLine($"{min} {max}");
    }

    

    class Solution
    {
        public static void Main(string[] args)
        {

            miniMaxSum([140638725, 436257910, 953274816, 734065819, 362748590]);
        }
    }

}