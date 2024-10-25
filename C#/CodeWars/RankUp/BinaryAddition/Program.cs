

static string AddBinary(int a, int b)
  {
   int number = a + b;
   List<int> binary = new List<int>{};
   //calculating binary  
   while(number > 0){
    //adding each number in list
     binary.Add(number%2); 
     number /= 2;   
   }
   //reversing the list binary
    binary.Reverse();
    string binaryReverse = "";
   //converting each int on list in string  
    foreach(int i in binary){
        binaryReverse += i.ToString();
    }
    return binaryReverse;
  }
  System.Console.WriteLine(AddBinary(20,5));

