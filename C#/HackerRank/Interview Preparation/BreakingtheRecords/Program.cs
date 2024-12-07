class Result
{

    /*
     * Complete the 'breakingRecords' function below.
     *
     * The function is expected to return an INTEGER_ARRAY.
     * The function accepts INTEGER_ARRAY scores as parameter.
     */

    public static List<int> breakingRecords(List<int> scores)
    {
        List<int> result = new List<int>() {0,0};
        int max = scores[0];
        int min = scores[0];

        foreach (int num in scores)
        {
           //check if num is more than max or less then min 
            if (num > max) result[0] += 1;
            
            if (num < min) result[1] += 1;

           //uptade value (max and min) 
            if (num > max) max = num;

            if (num < min) min = num;

        }
        return result;
    }
class Solution
{
    public static void Main(string[] args)
    {
            breakingRecords([3,4,21,36,10,28,35,5,24,42]);
    }

}

}

