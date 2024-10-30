 static string MakeComplement(string dna)
{   
  string complement = "";
  foreach(char ch in dna){
    switch(ch){
        case 'A':
            complement += "T";
            break;    
        case 'T':
            complement += "A";
            break;    
        case 'G':
            complement += "C";
            break;    
        case 'C':
            complement += "G";
            break;    
    }
  }
    return complement;
}

System.Console.WriteLine(MakeComplement("ATTGC"));