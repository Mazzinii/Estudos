
class Solution
{
    public static void Main(string[] args)
    {
        getTotalX([2, 6], [24,36]);

    }

    static int getTotalX(List<int> a, List<int> b)
    {
        int MaxValue = b.Max();

        //lista de multiplicação

        List<int> multiplicationArray = new List<int>();

        foreach (int i in a)
        {
            int value = 0;
            while (value < MaxValue)
            {
                value += i;
                multiplicationArray.Add(value);
            }
        }

        //fazer lista de fatoração 
    }
}




