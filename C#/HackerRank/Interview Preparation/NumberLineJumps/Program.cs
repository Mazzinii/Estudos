﻿class Result
{

    /*
     * Complete the 'kangaroo' function below.
     *
     * The function is expected to return a STRING.
     * The function accepts following parameters:
     *  1. INTEGER x1
     *  2. INTEGER v1
     *  3. INTEGER x2
     *  4. INTEGER v2
     */

    public static string kangaroo(int x1, int v1, int x2, int v2)
    {
        if (v1 <= v2) return "NO";

        if ((x2 - x1) % (v1 - v2) == 0) return "Yes";
        else 
            return "NO";
    }

class Solution
{
    public static void Main(string[] args)
    {

    }
}
}

