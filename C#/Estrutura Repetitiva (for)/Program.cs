
//Exerc 01
System.Console.Write("Escreva um número");
int x = int.Parse(Console.ReadLine());



for(int i = 1; i <= x ; i++){
    System.Console.WriteLine(i);
    i++;
}


//Exerc 02
System.Console.WriteLine("Escreva a quantidade de numeros:");
int numeros = int.Parse(Console.ReadLine());
int dentro = 0;
int fora = 0;


for(int i = 1; i <= numeros; i++){
    System.Console.Write($"Valor {i}:");
    int valores = int.Parse(Console.ReadLine());
    if(valores >= 10 && valores <= 20){
        dentro++;
    }else{
        fora++;
    }
}
System.Console.WriteLine($"{dentro} in");
System.Console.WriteLine($"{fora} out");


//Exec 03

System.Console.Write("numero de testes:");
int numero = int.Parse(Console.ReadLine());

for(int i = 1; i <= numero; i++){
    System.Console.Write($"numeros {i}");
    string[] vetor = Console.ReadLine().Split(' ');
    float valor1 = float.Parse(vetor[0]);
    float valor2 = float.Parse(vetor[1]);
    float valor3 = float.Parse(vetor[2]);

    float media =( (valor1 * 2) + (valor2 * 3) + (valor3 * 5) ) / 10;

    System.Console.WriteLine($"{media:F1}");
    
    
}


//Exerc 04

System.Console.WriteLine("digite quantos numeros quer dividir");
int vezes = int.Parse(Console.ReadLine());

for(int i = 0; i < vezes; i++){
    System.Console.WriteLine("Insira os numeros");
    string[] vet = Console.ReadLine().Split(' ');
    float numero1 = int.Parse(vet[0]);
    float numero2 = int.Parse(vet[1]);

    if(numero2 > 0 ){
        float divisao = numero1 / numero2;
        System.Console.WriteLine(divisao);
    }
    else{
        System.Console.WriteLine("Imposivel dividir");
    }
}


//Exerc 05

System.Console.Write("Fatorial:");
int fatorial = int.Parse(Console.ReadLine());
int resultado = 1;

for(int i = 1; i <= fatorial; i++){
        resultado = resultado * i;
}
System.Console.WriteLine(resultado);


//Exerc 06

System.Console.Write("Divisor:");
int divisor = int.Parse(Console.ReadLine());

for(int i = 1; i <= divisor; i++){
    if(divisor % i == 0){
        System.Console.WriteLine(i);
    }
}


//Exerc 07

System.Console.WriteLine("numero do cubo");
int cubo = 5;

for( int i = 1; i <= cubo; i++){

    int primeiro = i;
    int segundo = i * i;
    int terceiro = i * i * i;

    Console.WriteLine($"{primeiro} {segundo} {terceiro}");

}



