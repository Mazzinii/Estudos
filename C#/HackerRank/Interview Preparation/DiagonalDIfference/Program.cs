

class Result
{

    /*
     * Complete the 'diagonalDifference' function below.
     *
     * The function is expected to return an INTEGER.
     * The function accepts 2D_INTEGER_ARRAY arr as parameter.
     */

    public static int diagonalDifference(List<List<int>> arr)
    {
        int index = arr.Count;
        int rightDiagonal = 0;
        int leftDiagonal = 0;

        for (int i = 0; i < arr.Count; i++)
        {
            index--;
            rightDiagonal += arr[i][i];
            leftDiagonal += arr[i][index];
        }

        return Math.Max(rightDiagonal, leftDiagonal) - Math.Min(rightDiagonal, leftDiagonal);
    }
class Solution
{
        public static void Main(string[] args)
        {
            int a = 5;
            int b = -3;
            Console.WriteLine(a + b);
        }


    }

}

