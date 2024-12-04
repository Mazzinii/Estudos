using System.Text.RegularExpressions;

static bool IsPangram(string str)
  {
    SortedSet<char> result = new SortedSet<char>();
    // replace whith " " if is not a letter
    string newText = Regex.Replace(str.ToLower(), @"[^a-z]", "");
    // adding in SortedSet
    foreach(char c in newText){
        result.Add(c);
    }
    return result.Count == 26;

    /* Linq

    return str.Where(ch => Char.IsLetter(ch)).Select(ch => Char.ToLower(ch)).Distinct().Count() == 26;

    */
  }

  IsPangram("The quick brown fox jumps over the lazy dog.");
