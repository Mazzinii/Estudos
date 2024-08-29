//Exerc Proposto
using System.Globalization;

System.Console.WriteLine("Entre com seu nome completo:");
string nome = Console.ReadLine(); //Utilizado para entrada de dados

System.Console.WriteLine("Quantos quartos tem na sua casa?");
string quartos = Console.ReadLine();

System.Console.WriteLine("Entre com o preço de um produto:");
double preco = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

System.Console.WriteLine("Entre seu último nome, idade e altura (mesma linha):");
string[] vet = Console.ReadLine().Split(' ');
string ultimoNome = vet[0];
int idade = int.Parse(vet[1]);
float altura = float.Parse(vet[2],CultureInfo.InvariantCulture);

System.Console.WriteLine(nome);
System.Console.WriteLine(quartos);
System.Console.WriteLine(preco.ToString("F2", CultureInfo.InvariantCulture));
System.Console.WriteLine(ultimoNome);
System.Console.WriteLine(idade);
System.Console.WriteLine(altura.ToString("F2", CultureInfo.InvariantCulture));


// Exerc 01
System.Console.WriteLine("Digite o primeiro número:");
int numero1 = int.Parse(Console.ReadLine());
System.Console.WriteLine("Digite o segundo número:");
int numero2 = int.Parse(Console.ReadLine());

int soma = numero1 + numero2;

System.Console.WriteLine("Soma: " + soma);


//Exerc 02 

double raio = 150.00;
double calculo = 3.14159 * (raio * raio);

System.Console.WriteLine($"A = {calculo:F4}");


//Exerc 03

int a = 5;
int b = 6;
int c = 7;
int d = 8;

int diferenca = (a * b - c * d);
System.Console.WriteLine("DIFERENCA = " + diferenca);

//Exerc 04

int numero = 6;
int horas = 145;
float valor = 15.55F;

double salario = horas * valor;

System.Console.WriteLine("NUMBER = " + numero);
System.Console.WriteLine("SALARY = U$ " + salario.ToString("F2"));

//Exerc 05

string[] peca1 = Console.ReadLine().Split(' ');
string[] peca2 = Console.ReadLine().Split(' ');

int cod = int.Parse(peca1[0]);
int qntd = int.Parse(peca1[1]);
float preco1 = float.Parse(peca1[2]);

int cod2 = int.Parse(peca2[0]);
int qntd2 = int.Parse(peca2[1]);
float preco2 = float.Parse(peca2[2]);

double total = qntd * preco1 + qntd2 * preco2;

System.Console.WriteLine("VALOR A PAGAR: R$ " + total.ToString("F2"));


//Exerc 06

string[] numeros = Console.ReadLine().Split(' ');

float a1 = float.Parse(numeros[0]);
float b1 = float.Parse(numeros[1]);
float c1 = float.Parse(numeros[2]);

double triangulo = (a1 * c1) / 2;
double circulo = (c1 * c1) * 3.14159;
double trapezio = ((a1 + b1) * c1 ) / 2;
double quadrado = b1 * b1;
double retangulo = a1 * b1;

System.Console.WriteLine($"TRIANGULO : {triangulo:F3}");
System.Console.WriteLine($"CIRCULO : {circulo:F3}");
System.Console.WriteLine($"TRAPEZIO : {trapezio:F3}");
System.Console.WriteLine($"QUADRADO : {quadrado:F3}");
System.Console.WriteLine($"RETANGULO : {retangulo:F3}");