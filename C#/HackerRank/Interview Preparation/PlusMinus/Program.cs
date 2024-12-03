class Result
{

    /*
     * Complete the 'plusMinus' function below.
     *
     * The function accepts INTEGER_ARRAY arr as parameter.
     */

    public static void plusMinus(List<int> arr)
    {
       int length = arr.Count();   
       float positiveNumbers = arr.Where(x => x > 0).Count() ;
       float negativeNumbers = arr.Where(x => x < 0).Count() ;
       float zeroNumbers = arr.Where(x => x == 0).Count() ;
       
       Console.WriteLine((positiveNumbers / length).ToString("f6"));
       Console.WriteLine((negativeNumbers / length).ToString("f6"));
       Console.WriteLine((zeroNumbers / length).ToString("f6"));
         
    }

}

class Solution
{
    public static void Main(string[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine().Trim());

        List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

        Result.plusMinus(arr);
    }
}

