/*
  Count the number of Duplicates
  Write a function that will return the count of distinct case-insensitive
  alphabetic characters and numeric digits that occur more than once in the
  input string. The input string can be assumed to contain only alphabets
  (both uppercase and lowercase) and numeric digits.    
*/    
        
//--Code--// 

    //take each word in string and compare to string
    //dont count case sensitive 
    //if the word is in string add in array
    //return the length of array

static int DuplicateCount(string str)
  {
    str = str.ToLower();
    List<char> count = [];
    for(int i = 0; i < str.Length; i++){
        for(int j = 0; j < str.Length;j++){
            if(str[i] == str[j]){
                count.Add(str[i]);              
            }
            if(i == j){
                count.Remove(str[i]);
            }      
        }
    }   
        List<char> countUnique = count.Distinct().ToList();
        return countUnique.Count;
  }
  System.Console.WriteLine(DuplicateCount("aabBcde"));
