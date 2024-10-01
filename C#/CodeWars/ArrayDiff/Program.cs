
//array has a fixed length

System.Console.WriteLine(ArrayDiff([1, 2, 3], [1,2]));
 
 static int[] ArrayDiff(int[] a, int[] b){
    //return a when a is not in b array
    return a.Where(item => !b.Contains(item)).ToArray();
 }

