
//whitout method Count
static int CountBits(int n)
{
    //convert int to binary
    string binary = Convert.ToString(n,2);

    //count and return how many number 1 the binary has
    int count = 0;
    foreach(char chr in binary){
        if(chr == '1') count++;
        
    }

     return count;
}


//Whith method Count     
static int CountBitsC(int n)
{
    return Convert.ToString(n,2).Count(l => l == '1');
}