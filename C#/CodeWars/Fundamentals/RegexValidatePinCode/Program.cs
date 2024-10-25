using System.Text.RegularExpressions;

static bool ValidatePin(string pin)
  {
   if(pin.Length == 4 || pin.Length == 6){ 
     return Regex.IsMatch(pin, "^[0-9]{4}$|^[0-9]{6}$");
   }
   return false;   
  }
   

System.Console.WriteLine(ValidatePin("a234"));
