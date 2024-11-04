
int GetSum(int a, int b)
     {
       //take min int 
       int min = Math.Min(a,b);
       //take max int
       int max = Math.Max(a,b);
       //applying the formula 
       return (max - min + 1 ) * (max + min) / 2;

       /*
       int result = 0;
       for (int i = min; i <= max; i++)
       {       
         result += i;
       }
       return result;
       */  
     }

System.Console.WriteLine(GetSum(5,-1));     