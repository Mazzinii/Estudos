static IEnumerable<string> OpenOrSenior(int[][] data)
{       
    List<string> result = new List<string>();
    foreach(var i in data){
        if(i[0] >= 55 && i[1] > 7) result.Add("Senior");
        else result.Add("Open"); 
    }
    return result;
    /* using Linq
    return data.Select(member => member[0] >= 55 && member[1] > 7 ? "Senior" : "Open").ToList();
    */
}

OpenOrSenior([[18, 20], [45, 2], [61, 12], [37, 6], [21, 21], [78, 9]]);