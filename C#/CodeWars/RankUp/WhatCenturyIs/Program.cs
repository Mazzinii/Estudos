   static string WhatCentury(string year)
  {
    double yearint = Convert.ToDouble(year);
    yearint /= 100;
    string century = Math.Ceiling(yearint).ToString();
    char finalDigit = century[1];
    char firstDigit = century[0];
    
    if(firstDigit == '1'){
      return $"{century}th";
    }
    if(finalDigit == '1'){
      return $"{century}st";
    }  
    if(finalDigit == '2'){
      return $"{century}nd";
    }  
    if(finalDigit == '3'){
      return $"{century}rd";
    }
    return $"{century}th";
  }

System.Console.WriteLine(WhatCentury("2000"));