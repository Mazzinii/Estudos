class Result
{

    /*
     * Complete the 'countingValleys' function below.
     *
     * The function is expected to return an INTEGER.
     * The function accepts following parameters:
     *  1. INTEGER steps
     *  2. STRING path
     */

    public static int countingValleys(int steps, string path)
    {
        int result = 0;
        int count = 0;
      
        foreach(char p in path) 
        {
            if (p == 'D') count--;

            if (p == 'U')
            {
                count++;
                if (count == 0) result++;
            }
            
        }

        return result;
    }
class Solution
{
    public static void Main(string[] args)
    {
            countingValleys(10, "DDUDDUUDUU");
    }
}

}

