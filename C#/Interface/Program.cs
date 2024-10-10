
using Interface.Entities;
using Interface.Services;

System.Console.Write("Enter contract data: ");
int number = int.Parse(Console.ReadLine());
System.Console.Write("Date (dd/MM/yyyy): ");
DateTime date = DateTime.Parse(Console.ReadLine());
System.Console.Write("Contract value: ");
double value = double.Parse(Console.ReadLine());
System.Console.WriteLine("Enter number of installments: ");
int months = int.Parse(Console.ReadLine());

Contract contract= new Contract(number, date, value);

ContractService contractService= new ContractService(new PayPalService());

contractService.ProcessContract(contract, months);

Console.WriteLine("Installments: ");

foreach(Installment installment in contract.Installments){
    Console.WriteLine(installment);
}