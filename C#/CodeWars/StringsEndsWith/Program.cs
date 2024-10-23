 static bool Solution(string str, string ending)
  {
    //checing if ending length is bigger than str length
    //if so return false
    if(ending.Length > str.Length) return false;
    //calculating if ending is the end of str
    //if so return true, if not return false
    return str.Substring(str.Length - ending.Length, ending.Length) == ending;
  }


System.Console.WriteLine(Solution("sumo", "omo"));