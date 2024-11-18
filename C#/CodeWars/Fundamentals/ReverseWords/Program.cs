static string ReverseWords(string str)
{
    string[] word = new string(str.ToArray().Reverse().ToArray()).Split(" "); 
    return string.Join(" ", word.Reverse());

    /*Linq
    return string.Join(" ", str.Split(' ').Select(i => new string(i.Reverse().ToArray())));
    */

  
}

ReverseWords("This is an example!");
