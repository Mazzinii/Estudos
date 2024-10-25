  static string AlphabetPosition(string text)
  {
    //tranforming text in uppercase 
    string textUpper = text.ToUpper();
    //checking if the text has no words
    if (text.Length == 0 ){
        return "";
    }
    string result = "";
    //iterating the text
    foreach(char ch in textUpper){
        //checking if the word is betwen 'A' and 'Z' 
        if(ch >= 'A' && ch <= 'Z'){
            //calculating the position of the word
             string value = (ch - 'A' + 1).ToString();
             result += $"{value} ";
            
        }
    }
        //removing the final space of the string
       string finalResult = result.TrimEnd(); 
       return finalResult;
  }

  AlphabetPosition("The sunset sets at twelve o' clock.");
