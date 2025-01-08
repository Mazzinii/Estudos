

class Result
{

    /*
     * Complete the 'pickingNumbers' function below.
     *
     * The function is expected to return an INTEGER.
     * The function accepts INTEGER_ARRAY a as parameter.
     */

    public static int pickingNumbers(List<int> a)
    {
        //ordering array
        a.Sort();
        int result = 0;
        int max = 0;
        List<int> distinctNumbers = a.Distinct().ToList();

        if (distinctNumbers.Count == 1) max = a.Count;
        else
        {
            foreach (int number in distinctNumbers)
            {
                if (a.Contains(number + 1))
                {
                    result = a.Count(x => x == number) + a.Count(x => x == number + 1);

                    if (result > max)
                    {
                        max = result;
                    }
                }
            }
        }
        return max;
    }
class Solution
{
    public static void Main(string[] args)
    {
            pickingNumbers([4, 97, 5, 97, 97, 4, 97, 4, 97, 97, 97, 97, 4, 4, 5, 5, 97, 5, 97, 99,
            4, 97, 5, 97, 97, 97, 5, 5, 97, 4, 5, 97, 97, 5, 97, 4, 97, 5, 4, 4,
            97, 5, 5, 5, 4, 97, 97, 4, 97, 5, 4, 4, 97, 97, 97, 5, 5, 97, 4, 97,
            97, 5, 4, 97, 97, 4, 97, 97, 97, 5, 4, 4, 97, 4, 4, 97, 5, 97, 97, 97,
            97, 4, 97, 5, 97, 5, 4, 97, 4, 5, 97, 97, 5, 97, 5, 97, 5, 97, 97, 97]);
    }
}

}

