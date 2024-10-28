

static string DuplicateEncode(string word)
  {
    //to lower
    word = word.ToLower();
    Dictionary<char, int> values = new();
    //what letters appears more tha once
    foreach (char ch in word)
    {
        //increase count if values has character
        if (values.ContainsKey(ch)){
            values[ch]++;
        }
        else{
            values[ch] = 1;
        }
    }

    string result = "";
    for(int i = 0; i < word.Length; i++){
        
        result += values[word[i]] == 1 ? '(' : ')';
    }
    return result; 
  } 

  System.Console.WriteLine(DuplicateEncode("recede"));
