// Exerc 01
/*
Pessoa x,y;
x = new Pessoa();
y = new Pessoa();

System.Console.WriteLine("Dados da primeira pessoa:");
System.Console.Write("Nome: ");
x.Nome = Console.ReadLine();
System.Console.Write("Idade: ");
x.Idade = int.Parse(Console.ReadLine());

System.Console.WriteLine("Dados da segunda pessoa:");
System.Console.Write("Nome: ");
y.Nome = Console.ReadLine();
System.Console.Write("Idade: ");
y.Idade = int.Parse(Console.ReadLine());

if(x.Idade > y.Idade){
    System.Console.WriteLine("Pessoa mais velha: " + x.Nome);
}
else if(y.Idade == x.Idade){
    System.Console.WriteLine("As duas Pessoas possuem a mesma idade.");
}
else{
    System.Console.WriteLine("Pessoa mais velha: " + y.Nome);
}
*/
/*
// Exerc 02

Salario p1,p2;
p1 = new Salario();
p2 = new Salario();

System.Console.WriteLine("Dados do primero funcionário");
System.Console.Write("Nome: ");
p1.Nome = Console.ReadLine();
System.Console.Write("Salario: ");
p1.Valor = double.Parse(Console.ReadLine());

System.Console.WriteLine("Dados do segundo funcionário");
System.Console.Write("Nome: ");
p2.Nome = Console.ReadLine();
System.Console.Write("Salario: ");
p2.Valor = double.Parse(Console.ReadLine());


double media = (p1.Valor + p2.Valor) / 2;

System.Console.WriteLine("Salário médio = " + media);
*/
/*
// Exerc 02

using System.Globalization;

Retangulo x;
x = new Retangulo();



System.Console.WriteLine("Entre com a largura e altura do retângulo:");

x.Largura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
x.Altura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

System.Console.WriteLine("Area = " + x.Area().ToString("F2", CultureInfo.InvariantCulture));
System.Console.WriteLine("Area = " + x.Perimetro().ToString("F2", CultureInfo.InvariantCulture));
System.Console.WriteLine("Area = " + x.Diagonal().ToString("F2", CultureInfo.InvariantCulture));
*/
/*
using System.Globalization;

Funcionario novo;
novo = new Funcionario();

System.Console.WriteLine("Insira os dados pedidos");

novo.Nome = Console.ReadLine() ; 
novo.SalarioBruto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture) ;
novo.Imposto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

novo.SalarioLiquido();

System.Console.WriteLine(novo);

System.Console.WriteLine("Digite a porcentagem para aumentar o salário:");

double porcentagem = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

novo.Aumentar(porcentagem);

System.Console.WriteLine(novo);
*/
using System.Globalization;

Notas aluno;
aluno = new Notas();

System.Console.WriteLine("Nome do Aluno");
aluno.Nome = Console.ReadLine();
System.Console.WriteLine("Digite as três notas do aluno:");
aluno.Tri1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
aluno.Tri2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
aluno.Tri3 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

System.Console.WriteLine("NOTA FINAL = " + aluno.Media());

 System.Console.WriteLine(aluno.VerifMedia());


