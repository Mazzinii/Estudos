
static string ExpandedForm(long num) 
{   //transform num in string
    string numString = num.ToString();
    //declaring the beginning of power
    double power = numString.Length - 1;
    double number = 0;
    string result = "";
    foreach(var n in numString){
         //trasnform char in double
         double digit = Convert.ToDouble(n.ToString());
         //calculate each number
         number = digit * Math.Pow(10,power);
         //add to string
         if(number > 0) result += $"{number} ";
         //decrease power
         power--;   
    }
    //removing blank space from end and replace space between number with " + "
    return result.TrimEnd().Replace(" ", " + ");     
}
ExpandedForm(12);