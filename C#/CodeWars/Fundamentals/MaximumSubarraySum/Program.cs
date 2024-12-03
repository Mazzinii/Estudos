using System.Globalization;

internal class Program
{
    private static void Main(string[] args)
    {
        static int MaxSequence(int[] arr)
        {
            
            int max_actual = 0;
            int max_global = 0;

            foreach (int item in arr)
            {
                max_actual = Math.Max(item, item + max_actual);
                max_global = Math.Max(max_actual, max_global);
            }
            return max_global;

        }

        Console.WriteLine(MaxSequence(new int[] { -2, 1, -3, 4, -1, 2, 1, -5, 4 }));
    }
}
