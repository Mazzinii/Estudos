static int Grow(int[] x)
{
    int result = 1;
    foreach(int number in x) result *= number;
    return result;

    /*Linq
    return x.Aggregate((a,b) => a*b);
    */
}
System.Console.WriteLine(Grow([1, 2, 3, 4]));
