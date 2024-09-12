using System.Data.Common;
using Pedidos;
using Pedidos.Entities.Enums;
using Pedidos.Entities;

System.Console.WriteLine("Enter client data:");
System.Console.WriteLine("Name:");
string name = Console.ReadLine();

System.Console.WriteLine("Email:");
string email = Console.ReadLine();

System.Console.WriteLine("Birth date (DD/MM/YYYY)");
DateTime birth = DateTime.Parse(Console.ReadLine());

Client client = new Client(name,email,birth);

System.Console.WriteLine("Enter order data:");
System.Console.WriteLine("Status:");

OrderStatus status = Enum.Parse<OrderStatus>(Console.ReadLine());
DateTime now = DateTime.Now;

Order order = new Order(now, status,client);

System.Console.WriteLine("How many order to this order");
int orders = int.Parse(Console.ReadLine());

for(int i = 1; i <= orders; i++)
{
    System.Console.WriteLine($"Enter #{i} item data:");
    System.Console.WriteLine("Product name:");
    string productName = Console.ReadLine();
    System.Console.WriteLine("Product price:");
    double productPrice = double.Parse(Console.ReadLine());
    System.Console.WriteLine("Quantity:");
    int productQuantity = int.Parse(Console.ReadLine());

    Product products = new Product(productName, productPrice);

    OrderItem orderItems = new OrderItem(productQuantity, productPrice, products);

    order.AddItem(orderItems);


}

System.Console.WriteLine(Order);

