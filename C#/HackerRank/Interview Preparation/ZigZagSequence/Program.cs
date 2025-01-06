using System.Runtime.InteropServices.Marshalling;

class Solution
{
    static void Main(String[] args)
    {
        /* Enter your code here. Read input from STDIN. Print output to STDOUT. Your class should be named Solution */
        int sizeArray = int.Parse(Console.ReadLine());
        List<int> list = new List<int>();

        for(int i = 0; i < sizeArray; i++)
        {
            int number = int.Parse(Console.ReadLine());
            list.Add(number);
        }

        findZigZagSequence(list);
    }
    public static List<int> findZigZagSequence(List<int> arr)
    {
        //sort array
        arr.Sort();
        // put the biggest number in the middle
        int mid = (int)Math.Floor(arr.Count / 2.0);
        int last = arr[arr.Count - 1];
        //change middle number with last number
        arr[arr.Count - 1] = arr[mid];
        arr[mid] = last;
        int count = 1;

        //put the second part of arr in desc order
       for(int i = mid + 1; i < arr.Count; i++)
        {
            arr[i] = last - count;
            count++;
        }

       foreach(int i in arr)
        {
            Console.WriteLine(i);
        }

       return arr;
        

    }
}