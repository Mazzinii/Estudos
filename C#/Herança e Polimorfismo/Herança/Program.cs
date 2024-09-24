using System.ComponentModel;
using System.Globalization;
using Herança.Entities;

//instanciando a lista de produtos
List<Product> list = new List<Product>();

//pegando o numero de produtos do usuario
System.Console.Write("Enter the number of products: ");
int products = int.Parse(Console.ReadLine());

//iterando sobre o numero de produtos 
for(int i = 1; i <= products; i++){

    //pegando os dados do produto do usuario
    System.Console.WriteLine($"Product #{i} data: ");
    System.Console.Write("Common, used or imported (c/u/i)? ");
    char choice = char.Parse(Console.ReadLine());

    System.Console.Write("Name: ");
    string name = Console.ReadLine();
    System.Console.Write("Price: ");
    double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

    //verificando tipo do produto para adicionar parametros de cada classe
    if(choice == 'i'){
        System.Console.Write("Customs fee: ");
        double fee = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        list.Add(new ImportedProduct(name, price, fee));
    } else if(choice == 'u'){
        System.Console.Write("Manufacture date (DD/MM/YYYY): ");
        DateTime manafacture = DateTime.Parse(Console.ReadLine());
        list.Add(new UsedProduct(name, price, manafacture));
    } else if(choice == 'c'){
        list.Add(new Product(name,price));
    }

}


System.Console.WriteLine();
System.Console.WriteLine("PRICE TAGS:");

//mostrando informações dos produtos ao chamar o metodo
foreach(Product product in list){
    System.Console.WriteLine(product.PriceTag());
}