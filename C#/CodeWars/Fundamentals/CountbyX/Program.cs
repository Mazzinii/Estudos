 static int[] CountBy(int x, int n)
  {
    //know size of vector
    int arraySize = (x * n) / x;
    //define pace
    int pace = x;
    //start vector
    int[] z = new int[arraySize];
    //adding number in vector
    for(int i = 0; i < arraySize; i++){
        z[i] = x;
        x += pace;
    }
    return z;
  }
CountBy(2,5);
