class Result
{

    /*
     * Complete the 'birthday' function below.
     *
     * The function is expected to return an INTEGER.
     * The function accepts following parameters:
     *  1. INTEGER_ARRAY s
     *  2. INTEGER d
     *  3. INTEGER m
     */

    public static int birthday(List<int> s, int d, int m)
    {
        int count = 0;
        

        if (s.Count < m) return 0;

        int currentSum = 0;

        // verifico a primeira janela 
        for (int i = 0; i < m; i++)
        {
            currentSum += s[i];
        }

        if (currentSum == d) count++;

        //movo para a proxima janela

        for(int i = m; i < s.Count; i++)
        {
            // somo o numero atual e retiro o numero anterior
            currentSum += s[i] - s[i - m]; 
            if (currentSum == d) count++;
        }

        return count;
    }
class Solution
{
    public static void Main(string[] args)
    {
            birthday([2, 2, 1, 3, 2], 4, 2);
    }
}

}

