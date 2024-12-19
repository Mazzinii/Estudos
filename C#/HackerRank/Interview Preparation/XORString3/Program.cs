namespace Solution
{
    class Solution
    {
        static void Main(string[] args)
        {
            /* Enter your code here. Read input from STDIN. Print output to STDOUT */
            string number1 = Console.ReadLine();
            string number2 = Console.ReadLine();
            Console.WriteLine(stringsXor(number1, number2));


        }

   public static string stringsXor(string s, string t)
        {
            string result = "";

            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == t[i]) result += "0";
                else result += "1";

            }

            return result;
        }
    }
}