using Generics.Entities;
using Generics.Services;
using System.Globalization;

List<Product> product = new List<Product>();

System.Console.Write("Enter the number of itens in array: ");
int count = int.Parse(Console.ReadLine());

for(int i = 1; i <= count; i++){
    Console.WriteLine("Enter name and price: ");
    //separando itens pela ","
    string[] vect = Console.ReadLine().Split(",");
    //apontando primeiro indice para o nome
    string name = vect[0];
    //apontando segundo indice para o preço
    double price = double.Parse(vect[1], CultureInfo.InvariantCulture);
    //adicionando na lista
    product.Add(new Product(name, price));
}
//instanciando o service
CalculationService calculationService= new CalculationService();

//comparando com o tipo product
Product max = calculationService.Max(product);
System.Console.WriteLine(max);

