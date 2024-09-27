using System.Globalization;
using Bank.Entities;
using Bank.Entities.Exceptions;

try
{
    System.Console.WriteLine("Enter account data");
    System.Console.Write("Number: ");
    int number = int.Parse(Console.ReadLine());
    System.Console.Write("Holder: ");
    string holder = Console.ReadLine();
    System.Console.Write("Initial balance: ");
    double balance = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
    System.Console.Write("Withdraw limit: ");
    double withdrawlimit = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);


    Account account= new(number, holder, balance, withdrawlimit);

    System.Console.WriteLine("");

    System.Console.Write("Enter amount for withdraw: ");
    double withdraw = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
    account.Withdraw(withdraw);
    System.Console.WriteLine(account);
}
catch(DomainExceptions e){
    System.Console.WriteLine("Withdraw error: " + e.Message);
}

