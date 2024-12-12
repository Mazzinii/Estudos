class Result
{

    /*
     * Complete the 'flippingBits' function below.
     *
     * The function is expected to return a LONG_INTEGER.
     * The function accepts LONG_INTEGER n as parameter.
     */

    public static long flippingBits(long n)
    {
        string binary = Convert.ToString(n,2).PadLeft(32,'0');
        string result = "";

        string resultBinary = binary.Replace(x => x == 0 ? "1" : "0");
        

        foreach(char b in binary) 
        {
            if ((int)Char.GetNumericValue(b) == 0) result += "1";
            if ((int)Char.GetNumericValue(b) == 1) result += "0";
        }

        return (long)Convert.ToInt64(result,2);
                
    }

class Solution
{
    public static void Main(string[] args)
    {
            flippingBits(1);  
    }
}

}

