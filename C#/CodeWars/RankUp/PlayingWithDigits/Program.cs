

static long digPow(int n, int p) {
	if(p < 0 || n < 0){
      return -1;
    }
    string nStr = n.ToString();
    long k = 0;
    foreach(char c in nStr){
        int digit = (int)char.GetNumericValue(c);
        k += (int)Math.Pow(digit,p);
        p++;
    }
       int nNum = (int)n;
       double result = k / nNum;
       
       if( result * nNum != k){
        return -1;
       }
       return (long)result;
       
}
System.Console.WriteLine(digPow(92, 1));





