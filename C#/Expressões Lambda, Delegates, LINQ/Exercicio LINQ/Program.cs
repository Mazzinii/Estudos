using System.Globalization;
using Exercicio_LINQ.Entities;

//path
System.Console.Write("Enter full file path: ");
string path = Console.ReadLine();

var employes = new List<Employes>();

using (StreamReader sr = File.OpenText(path)){
    while(!sr.EndOfStream){
        string[] vet = sr.ReadLine().Split(',');
        string name = vet[0];
        string email = vet[1];
        double salary = double.Parse(vet[2], CultureInfo.InvariantCulture);
        employes.Add(new Employes(name,email,salary));
    }
}
//search with salary
System.Console.Write("Enter salary: ");
double search = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
System.Console.WriteLine($"Email of people whose salary is more than {search}");

List<string> resultEmail = employes.Where(x => x.Salary > search).Select(x => x.Email).Order().ToList();

foreach(string email in resultEmail){
    System.Console.WriteLine(email);
}

//sum of salary who starts whith 'M'
double resultSalary = employes.Where(x => x.Name[0] == 'M').Select(x => x.Salary).Sum();
System.Console.WriteLine($"Sum of salary of people whose name starts with 'M': {resultSalary.ToString("F2", CultureInfo.InvariantCulture)}");


