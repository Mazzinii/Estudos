using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;



class Result
{

    /*
     * Complete the 'maxMeetings' function below.
     *
     * The function is expected to return an INTEGER.
     * The function accepts INTEGER_ARRAY effectiveness as parameter.
     */

    public static int maxMeetings(List<int> effectiveness)
    {
        effectiveness.Sort();
        return effectiveness[effectiveness.Count - 1] + effectiveness[effectiveness.Count - 2];
    }
class Solution
{
    public static void Main(string[] args)
    {
            maxMeetings([3, -3, 0, 2]);
    }
}

}


