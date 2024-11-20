 static int GetAge(string inputString)
  {
    return int.Parse(inputString.Substring(0, 1));
    
    /*subtraction from 0 returns a int
    return inputString[0] - '0';
    */
  }
