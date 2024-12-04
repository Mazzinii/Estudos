 static Dictionary<char, int> Count(string str)
  {
    Dictionary<char, int> dict = new Dictionary<char,int>();
    foreach(char s in str){
        if(!dict.ContainsKey(s)){
            dict.Add(s,str.Count(x => x == s));
        }    
    }
    return dict;

    /* Linq
    return str.GroupBy(c => c).ToDictionary(g => g.Key, g => g.Count());
    */
  }

  Count("aba");