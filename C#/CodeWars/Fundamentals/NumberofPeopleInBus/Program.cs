 
 static int Number(List<int[]> peopleListInOut){
    int result = 0;
          
    foreach(var list in peopleListInOut){
        result += list.ElementAt(0) - list.ElementAt(1);
    }
    return result;
}
List<int[]> peopleList = new List<int[]>(){new []{10,0},new []{3,5}, new []{5,8}};
System.Console.WriteLine(Number(peopleList));