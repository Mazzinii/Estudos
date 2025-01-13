class Result
{

    /*
     * Complete the 'rotateLeft' function below.
     *
     * The function is expected to return an INTEGER_ARRAY.
     * The function accepts following parameters:
     *  1. INTEGER d
     *  2. INTEGER_ARRAY arr
     */

    public static List<int> rotateLeft(int d, List<int> arr)
    {
        List<int> result = new List<int>();
        int count = 0;
        while(count < d)
        {
            int temp = arr[0];
            arr.Remove(arr[0]);
            result = arr;
            result.Add(temp);
            count++;
        }
        return result;
        
    }
class Solution
{
    public static void Main(string[] args)
    {
            rotateLeft(2,[1, 2, 3, 4, 5]);
    }
}


}
