
using System.Globalization;
using Exerc.Entities;

List<Tax> list = [];

System.Console.Write("Enter the number of tax payers: ");
int number = int.Parse(Console.ReadLine());

for(int i = 1; i <= number; i++)
{
    System.Console.WriteLine($"Tax payer #{i} data:");

    System.Console.Write("Individual or company (i/c)? ");
    char ch = char.Parse(Console.ReadLine());

    System.Console.Write("Name: ");
    string name = Console.ReadLine();

    System.Console.Write("Anual income: ");
    double anualIncome = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

    if(ch == 'i'){
        System.Console.Write("Health expenditures: ");
        double healthExpend = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        list.Add(new PhysicsTax(name,anualIncome,healthExpend)); 
    }else {
        System.Console.Write("Number of employees: ");
        int employees = int.Parse(Console.ReadLine());
        list.Add(new JuridicTax(name, anualIncome, employees));
    }

}

System.Console.WriteLine();
System.Console.WriteLine("TAXES PAID:");

double sum = 0;
foreach(Tax tax in list){

    System.Console.WriteLine(tax);
    sum += tax.TaxCalc();
}

System.Console.WriteLine();
System.Console.WriteLine($"TOTAL TAXES: {sum:F2}");


