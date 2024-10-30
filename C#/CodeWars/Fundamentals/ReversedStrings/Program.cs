 static string Solution(string str) 
  {
   return new string(str.ToArray().Reverse().ToString());
  }
  
System.Console.WriteLine(Solution("World"));

/*
str.ToArray(): Converte a string str em um array de caracteres.
Reverse(): Inverte a ordem dos caracteres.
ToArray(): Converte o resultado do Reverse() de volta para um array.
new string(...): Cria uma nova string a partir do array invertido.
*/