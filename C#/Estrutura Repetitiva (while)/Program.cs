
//Exerc 01
 System.Console.Write("Digite uma senha");
 int senha = int.Parse(Console.ReadLine());

 while(senha != 2002){
    System.Console.WriteLine("Senha invalida");
    System.Console.Write("Digite uma senha");
    senha = int.Parse(Console.ReadLine());
 }
 System.Console.WriteLine("Acesso Permitido");


//Exerc 02

System.Console.WriteLine("Digite as coordenadas");
string[] cordenadas = Console.ReadLine().Split(' ');
int x = int.Parse(cordenadas[0]);
int y = int.Parse(cordenadas[1]);

while(x != 0 && y != 0){
   if(x > 0 && y > 0 ){
      System.Console.WriteLine("primeiro");
   }
   else if( x > 0 && y < 0){
      System.Console.WriteLine("quarto");
   }
   else if(x < 0 && y < 0){
      System.Console.WriteLine("terceiro");
   }
   else{
      System.Console.WriteLine("segundo");
   }
   System.Console.WriteLine("Digite as coordenadas");
    cordenadas = Console.ReadLine().Split(' ');
    x = int.Parse(cordenadas[0]);
    y = int.Parse(cordenadas[1]);
   
}
System.Console.WriteLine("Não aceitamos numeros nulos");


//Exerc 03
System.Console.WriteLine("Insira o cod: 1.Álcool 2.Gasolina 3.Diesel 4.Fim");
int cod = int.Parse(Console.ReadLine());
int alcool = 0;
int gasolina = 0;
int diesel = 0;


while(cod != 4){
   if(cod == 1){
      alcool++;
      System.Console.WriteLine("Alcool: " + alcool);
      System.Console.WriteLine("Insira o cod: 1.Álcool 2.Gasolina 3.Diesel 4.Fim");
      cod = int.Parse(Console.ReadLine());
   }
   else if(cod == 2){
      gasolina++;
      System.Console.WriteLine("Gasolina: " + gasolina);
      System.Console.WriteLine("Insira o cod: 1.Álcool 2.Gasolina 3.Diesel 4.Fim");
      cod = int.Parse(Console.ReadLine());
   }
   else if(cod == 3){
      diesel++;
      System.Console.WriteLine("Diesel: " + diesel);
      System.Console.WriteLine("Insira o cod: 1.Álcool 2.Gasolina 3.Diesel 4.Fim");
      cod = int.Parse(Console.ReadLine());
   }
   else{
      cod = int.Parse(Console.ReadLine());
   }
}
System.Console.WriteLine("Muito Obrigado");

