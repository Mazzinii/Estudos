//Exerc 01
int numero = 0;

if(numero < 0){
    System.Console.WriteLine("NEGATIVO");
} 
else{
    System.Console.WriteLine("POSITIVO");
}

//Exerc 02 

int x2 = 0;

if(x2 % 2 == 0){
    System.Console.WriteLine("PAR");
}
else{
    System.Console.WriteLine("IMPAR");
}

//Exerc 03

int a = 24;
int b = 6;

if(a % b == 0 || b % a  == 0){
    System.Console.WriteLine("Sao Multiplos");
}
else{
    System.Console.WriteLine("Nao sao Multiplos");
}

//Exerc 04

int inicial = 2;
int final = 16;
int hora = 0;

if( inicial < final){
    hora = final - inicial;
}
else{
    hora = 24 - inicial + final;  
}
System.Console.WriteLine($"O JOGO DUROU {hora} HORA(s)");

//Exerc 05

double numero1 = 101;

if(numero1 < 0){
    System.Console.WriteLine("Fora de Intervalo");
}
else if(numero1 >= 0 && numero1 <= 25){
    System.Console.WriteLine("Intervalo (0,25)");
}
else if(numero1 <= 50){
    System.Console.WriteLine("Intervalo (25,50)");
}
else if(numero1 <= 75){
    System.Console.WriteLine("Intervalo (50,75)");
}
else if(numero1 <= 100){
    System.Console.WriteLine("Intervalo (75,100)");
}
else{
    System.Console.WriteLine("Fora do intervalo");
}

//Exerc 06

double quadrante1 = 0.0;
double quadrante2 = 0.0;


if(quadrante1 == 0 && quadrante2 == 0){
    System.Console.WriteLine("Origem");
}
else if(quadrante1 > 0 && quadrante2 > 0){
    System.Console.WriteLine("Q1");
}
else if(quadrante1 < 0 && quadrante2 < 0){
    System.Console.WriteLine("Q3");
}
else if(quadrante1 > 0 && quadrante2 < 0){
    System.Console.WriteLine("Q4");
}
else if(quadrante1 < 0 && quadrante2 > 0){
    System.Console.WriteLine("Q2");
}

//Exerc 07

double salario = 3002.00;
double imposto = 0;

if(salario <= 2000.0){
    imposto = 0.0;
}else if(salario <= 3000.0){
    imposto = (salario - 2000) * 0.08;
}
else if(salario <= 4500.0){
    imposto = (salario - 3000) * 0.18 + 1000.0 * 0.08;
}
else{
    imposto = (salario - 4500) * 0.28 + 1500.0 * 0.18 + 1000.0 * 0.08;
}
if(imposto == 0.0){
    System.Console.WriteLine("Insento"); 
}
else{
    System.Console.WriteLine(imposto);
}       