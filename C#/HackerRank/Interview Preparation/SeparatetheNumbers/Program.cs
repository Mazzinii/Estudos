
using System.Text;


class Result
{

    /*
     * Complete the 'separateNumbers' function below.
     *
     * The function accepts STRING s as parameter.
     */

    public static void separateNumbers(string s)
    {
        double lenght = s.Length % 2 == 0 ? s.Length / 2 : Math.Floor(s.Length / 2.0);

        for (int i = 1; i <= lenght; i++)
        {
            String firstNumStr = s.Substring(0, i);
            long firstNum = long.Parse(firstNumStr);
            StringBuilder sb = new StringBuilder(firstNumStr);

            long nextNum = firstNum + 1;

            while (sb.Length < s.Length)
            {
                sb.Append(nextNum);
                nextNum++;
            }

            if (sb.Equals(s))
            {
                Console.WriteLine("YES " + firstNum);
                return;
            }

        }
        Console.WriteLine("NO");

    }

class Solution
{
    public static void Main(string[] args)
    {
            separateNumbers("1234");
        
    }
}

}


