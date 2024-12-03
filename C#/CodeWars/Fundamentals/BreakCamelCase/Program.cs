 using System.Text.RegularExpressions;
 static string BreakCamelCase(string str)
  {
    string[] vect = Regex.Split(str, "(?=[A-Z])");
    string result = "";

    foreach(string vectStr in vect){
      result += $" {vectStr}";
    }
    return result.TrimStart();

    /* Linq
    return String.Concat(str.Select(c => char.IsUpper(c) ? "" + c : c.ToString()));
    */
  }

BreakCamelCase("camelCasing");