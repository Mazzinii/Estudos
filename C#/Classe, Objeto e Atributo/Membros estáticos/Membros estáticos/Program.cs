// Usando classes sem instancia 

using System.Globalization;

System.Console.WriteLine("Qual é a cotação do dólar?");
double cotaçao = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

System.Console.WriteLine("Quantos dólares você vai comprar?");
double valor = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

System.Console.WriteLine("Valor a ser pago em reais = " + ConversorDeMoedas.Cambio(cotaçao,valor).ToString("F2", CultureInfo.InvariantCulture));

