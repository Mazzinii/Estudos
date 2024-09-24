
using Pedidos;
using Pedidos.Entities.Enums;
using System.Globalization;

System.Console.WriteLine("Enter client data:");
System.Console.Write("Name: ");
string name = Console.ReadLine();

System.Console.Write("Email: ");
string email = Console.ReadLine();

System.Console.Write("Birth date (DD/MM/YYYY): ");
DateTime birth = DateTime.Parse(Console.ReadLine());

//instanciando o cliente 
Client client = new Client(name,email,birth);

System.Console.WriteLine("Enter order data:");
System.Console.Write("Status: ");

OrderStatus status = Enum.Parse<OrderStatus>(Console.ReadLine());
DateTime now = DateTime.Now;

//instanciando a order
Order order = new Order(now, status,client);

System.Console.Write("How many order to this order? ");
int orders = int.Parse(Console.ReadLine());

//iterando sobre o numero de pedidos do usuario 
for(int i = 1; i <= orders; i++)
{
    //adicionando produto 
    System.Console.WriteLine($"Enter #{i} item data:");
    System.Console.Write("Product name: ");
    string productName = Console.ReadLine();
    System.Console.Write("Product price: ");
    double productPrice = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
    System.Console.Write("Quantity: ");
    int productQuantity = int.Parse(Console.ReadLine());

    //instanciando products
    Product products = new Product(productName, productPrice);

    //adicionando produto na lista OrderItem
    OrderItem orderItems = new OrderItem(productQuantity, productPrice, products);

    //chamando o metodo de adicionar item
    order.AddItem(orderItems);
}
System.Console.WriteLine();

//chamando o metodo ToString()
System.Console.WriteLine(order);

