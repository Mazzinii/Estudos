class Result
{
    public static int pageCount(int n, int p)
    {
        if (n == p) return 0;
        else
        {
            //number of pages
            int pages = (n % 2) == 0 ? (int)Math.Ceiling((n + 1) / 2.0) : (int)Math.Ceiling(n / 2.0);
            //seached page
            int searchedPage = (p % 2) == 0 ? (int)Math.Ceiling((p + 1) / 2.0) : (int)Math.Ceiling(p / 2.0);
            //check min and max value
            int result = Math.Min((pages - searchedPage), (int)Math.Floor(p / 2.0));
            //return min 
            return result;
        } 
       


    }

    class Solution
    {
        public static void Main(string[] args)
        {
            pageCount(6, 5);
        }
    }
}



