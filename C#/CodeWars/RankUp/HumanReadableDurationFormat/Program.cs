 static string formatDuration(int seconds){
    if(seconds == 0) return "now";
    //calculate timespan from seconds
    var time = TimeSpan.FromSeconds(seconds);
    //calculating Year
    int year = time.Days / 365;
    int day = time.Days - (year * 365);
    //know if number is plural or single
    string letterY = year > 1 ? "s" : "";
    string letterD = time.Days > 1 ? "s" : "";
    string letterH = time.Hours > 1 ? "s" : "";
    string letterM = time.Minutes > 1 ? "s" : "";
    string letterS =  time.Seconds > 1 ? "s" : "";

    //know if second has and or no 
    string wordAndS = time.Seconds >= 60 ? "and" : "";
    string wordAndD =  time.Hours > 0 && time.Minutes > 0 ? "," : " and";
    wordAndD = time.Hours < 0 && time.Minutes > 0 && time.Seconds > 0 ? " and" : ",";
    string wordAndH = time.Minutes > 0 && time.Seconds > 0 ? "," : " and";
    string wordAndM = time.Seconds > 0 ? " and" : "";

    //return time
    string dateYear = year > 0 ? $"{year} year{letterY}," : "";  
    string dateDays = time.Days > 0 ? $" {day} day{letterD}{wordAndD}" : "";  
    string dateHours = time.Hours > 0 ? $" {time.Hours} hour{letterH}{wordAndH}" : "";
    string dateMinutes = time.Minutes > 0 ? $" {time.Minutes} minute{letterM}{wordAndM}" : "";
    string dateSeconds =  time.Seconds > 0 ? $"{wordAndS} {time.Seconds} second{letterS}" : "";   
      
    string completeDate = $"{dateYear}{dateDays}{dateHours}{dateMinutes}{dateSeconds}";
    return completeDate.Trim();
    
  }

  formatDuration(120);







