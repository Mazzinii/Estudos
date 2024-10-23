static string GetMiddle(string s)
  {
    //checking if the string has one word
    if(s.Length == 0){
      return s;
    }
    //calculating the middle of the string 
    int middle = s.Length / 2;
    //if string has odd length return 2 letters (the middle character and the previous one)
    //if not return the middle word
    return s.Length % 2 == 0 ? $"{s[middle]}{s[middle -1]}" : s[middle].ToString() ;
  }

