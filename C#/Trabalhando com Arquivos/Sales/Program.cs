
using System.Globalization;

//read the path of the file
string sourcePath = @"C:\Users\lmazz\Downloads\archive\file1.txt";
//create a new directory
Directory.CreateDirectory(@"C:\Users\lmazz\Downloads\archive\out");
string targetPath = @"C:\Users\lmazz\Downloads\archive\out\sumary.csv";

try{
    //access the file
    string[] lines = File.ReadAllLines(sourcePath);
    
    

    using (StreamWriter sw = File.AppendText(targetPath)){
       foreach(string line in lines){
            
            //read each line and transform in to array with sep (,) 
            string[] split = line.Split(',');

            //treat the data
            int quantity = int.Parse(split[2]);
            double price = double.Parse(split[1], CultureInfo.InvariantCulture);
            double newPrice = price * quantity;

            //save the file as a new archive
            sw.WriteLine($"{split[0]}, " + newPrice.ToString("F2", CultureInfo.InvariantCulture));
       }

    }
              
    
}
catch(IOException e){
    System.Console.WriteLine("An error ocurred");
    Console.WriteLine(e.Message);
}






