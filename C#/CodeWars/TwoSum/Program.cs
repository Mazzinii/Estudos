
using System.Security.Cryptography.X509Certificates;

static int[] TwoSum(int[] numbers, int target)
  {
    //iterate each number in array numbers
    //check two numbers who added together is target
    int[] result = new int[2];
    for(int i = 0; i < numbers.Length; i++){
        for(int j = 0; j < numbers.Length;j++){
            if((numbers[i] + numbers[j]) == target && i != j){
                //return array whith the index 
                result = new int[] {Array.IndexOf(numbers,numbers[i]),Array.LastIndexOf(numbers,numbers[j])};
                
            }
        }
    } 
    Array.Sort(result);
    return result;
  }

  
TwoSum([2, 2, 3 ], 4);