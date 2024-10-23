static string GetMiddle(string s)
  {
    //calculating the middle of the string 
    int middle = s.Length / 2;
    //if string has odd length return 2 letters (the middle character and the previous one)
    //if not return the middle word
    return s.Length % 2 == 0 ? s.Substring(middle -1, 2) : s[middle].ToString();
  }

  System.Console.WriteLine(GetMiddle("A"));

  

