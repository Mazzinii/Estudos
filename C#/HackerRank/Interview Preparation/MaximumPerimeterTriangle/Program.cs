using System.Diagnostics.CodeAnalysis;

class Result
{

    /*
     * Complete the 'maximumPerimeterTriangle' function below.
     *
     * The function is expected to return an INTEGER_ARRAY.
     * The function accepts INTEGER_ARRAY sticks as parameter.
     */

    public static List<int> maximumPerimeterTriangle(List<int> sticks)
    {
        List<int> result = new List<int>(3){0,0,0};
        List<int> wrongResult = new List<int>(){-1};
        long perimeter = 0;
        long max = 0;

        for(int i = 0;  i < sticks.Count - 2; i++)
        {
            perimeter = (long)sticks[i] + sticks[i + 1] + sticks[i + 2];

            if (sticks[i] + sticks[i+1] > sticks[i + 2] && perimeter > max)
            {
                max = perimeter;
                result[0] = sticks[i];
                result[1] = sticks[i + 1];
                result[2] = sticks[i + 2];
            }
            
        }
        if (result.Count(x => x == 0) == 3) return wrongResult;
        else return result;
    }

class Solution
{
    public static void Main(string[] args)
    {
            Console.WriteLine(maximumPerimeterTriangle([1000000000, 1000000000, 1000000000, 1000000000, 1000000000 ,1000000000])); 
    }
}
}

