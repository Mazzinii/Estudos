﻿using System.Globalization;

class Result
{

    /*
     * Complete the 'timeConversion' function below.
     *
     * The function is expected to return a STRING.
     * The function accepts STRING s as parameter.
     */

    public static string timeConversion(string s)
    {
        DateTime hour = DateTime.ParseExact(s, "hh:mm:sstt", CultureInfo.InvariantCulture);
        return hour.ToString("HH:mm:ss");
         
    }

class Solution
{
    public static void Main(string[] args)
    {
            timeConversion("07:05:45PM");
    }
}

}

