
class Solution
{
    public static void Main(string[] args)
    {
        getTotalX([2, 6], [24,36]);

    }

    static int getTotalX(List<int> a, List<int> b)
    {
        //defifnindo numero max da multiplicação
        int MaxValue = b.Max();

        //definindo quantas vezes o numero deve aparecer para estar presente em todas as listas
        int ocurrance = a.Count() + b.Count();

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

        //lista da divisão 
        List<int> divisionArray = new List<int>();
        foreach (int value in b)
        {
            for (int j = value; j > 0; j--)
            {
                if (value % j == 0)
                {
                    divisionArray.Add(j);
                }
            }
        }

        //concatenando as duas listas
        List<int> allNumbers = multiplicationArray.Concat(divisionArray).ToList();
        allNumbers.Sort();

        //declarando uma nova lista de numeros visitados
        List<int> visitedNumbers = new List<int>();

        int result = 0;

        foreach (int value in allNumbers)
        {
            //verfificando se o numero nao esta nos numeros visitados 
            if(!visitedNumbers.Contains(value))
            {
                visitedNumbers.Add(value);
                if (allNumbers.Count(x => x == value) == ocurrance) result++;
                
            }
        }

        return result;
    }
}




