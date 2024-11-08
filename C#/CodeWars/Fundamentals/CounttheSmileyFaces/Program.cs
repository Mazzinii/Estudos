 static int CountSmileys(string[] smileys) 
  {
    int count = 0;
    foreach(string smiley in smileys){
        if(smiley.Length == 3){
             if((smiley[0] == ':' || smiley[0] == ';') && (smiley[1] == '-' || smiley[1] == '~') && (smiley[2] == ')' || smiley[2] == 'D')) count++;
        }
        if(smiley.Length == 2){
            if((smiley[0] == ':' || smiley[0] == ';') && (smiley[1] == ')' || smiley[1] == 'D')) count++;
        }
    }
    return count;

    /* Using Regex
        return smileys.Count(s => Regex.IsMatch(s, @"^[:;]{1}[~-]{0,1}[\)D]{1}$"));
    */
  }
CountSmileys([":)", ":(", ":D", ":O", ":;"]);