
System.Console.Write("Enter file full path:");
string path = Console.ReadLine();
//C:\Users\lmazz\Downloads\CodeGit\Estudos\C#\Generics, Set, Dictionary\Dictionary\in.txt

 Dictionary<string, int> data = new Dictionary<string, int>();

try{
    using (StreamReader sr = File.OpenText(path)) {

       
        
        while(!sr.EndOfStream){
            //read line and transform in array with sep (,)
            string[] split = sr.ReadLine().Split(',');
            string candidate = split[0];
            int vote = int.Parse(split[1]);

            if(data.ContainsKey(candidate)){
                data[candidate] += vote;
            }
            else{
                data[candidate] = vote;
            }

        }    
    }
        
}                  
catch (Exception ex) {
    Console.WriteLine(ex.Message);
}

foreach(var line in data){
    Console.WriteLine(line.Key + ":" + line.Value);
}