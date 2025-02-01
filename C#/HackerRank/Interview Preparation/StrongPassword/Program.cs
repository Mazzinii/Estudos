using System.Text.RegularExpressions;

class Result
{

    /*
     * Complete the 'minimumNumber' function below.
     *
     * The function is expected to return an INTEGER.
     * The function accepts following parameters:
     *  1. INTEGER n
     *  2. STRING password
     */

    public static int minimumNumber(int n, string password)
    {
        // Return the minimum number of characters to make the password strong

        int result = 4;


        
            string lowerLetter = @"[a-z]";
            string upperLetter = @"[A-Z]";
            string special = @"\W";
            string numbers = @"\d";

            Regex regexLow = new Regex(lowerLetter);
            Regex regexUpp = new Regex(upperLetter);
            Regex regexSpecial= new Regex(special);
            Regex regexNumbers = new Regex(numbers);

            if (regexLow.IsMatch(password)) result--;
            if (regexUpp.IsMatch(password)) result--;
            if (regexSpecial.IsMatch(password)) result--;
            if (regexNumbers.IsMatch(password)) result--;

        if (n > 6) return result;
        if (n + result < 6) return 6 - n;
        if (n + result > 6) return result;
        return result;
        

    }

class Solution
{
    public static void Main(string[] args)
    {
            minimumNumber(7, "AUzs-nV");

    }
}

}

