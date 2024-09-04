using System.Globalization;

System.Console.WriteLine("Entre com o número da conta:");
int conta = int.Parse(Console.ReadLine());

System.Console.WriteLine("Entre com o titular da conta:");
string nome = Console.ReadLine();

Console.WriteLine("Haverá depósito inicial (s/n)");
char opcao = char.Parse(Console.ReadLine());

double saldoInicial = 0;

if (opcao.ToString() == "s"){
    System.Console.WriteLine("Entre o valor de depósito inicial:");
     saldoInicial = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
    System.Console.WriteLine();
}
else {
    System.Console.WriteLine();
}    

Banco banco= new Banco(saldoInicial,conta,nome);

System.Console.WriteLine("Dados da Conta:");
System.Console.WriteLine(banco);

System.Console.WriteLine("Entre com um valor para depósito:");
double deposito = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

banco.Deposito(deposito);

System.Console.WriteLine("Dados da conta atualizados:");
System.Console.WriteLine(banco);

System.Console.WriteLine("Entre com um valor para depósito:");
double saque = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

banco.Saque(saque);

System.Console.WriteLine("Dados da conta atualizados:");
System.Console.WriteLine(banco);








