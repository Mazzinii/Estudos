using System.Data.Common;
using Pedidos;
using Pedidos.Entities.Enums;
using Pedidos.Entities;
using System.Globalization;

System.Console.WriteLine("Enter client data:");
System.Console.Write("Name: ");
string name = Console.ReadLine();

System.Console.Write("Email: ");
string email = Console.ReadLine();

System.Console.Write("Birth date (DD/MM/YYYY): ");
DateTime birth = DateTime.Parse(Console.ReadLine());

Client client = new Client(name,email,birth);

System.Console.WriteLine("Enter order data:");
System.Console.Write("Status: ");

OrderStatus status = Enum.Parse<OrderStatus>(Console.ReadLine());
DateTime now = DateTime.Now;

Order order = new Order(now, status,client);

System.Console.Write("How many order to this order? ");
int orders = int.Parse(Console.ReadLine());

for(int i = 1; i <= orders; i++)
{
    System.Console.WriteLine($"Enter #{i} item data:");
    System.Console.Write("Product name: ");
    string productName = Console.ReadLine();
    System.Console.Write("Product price: ");
    double productPrice = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
    System.Console.Write("Quantity: ");
    int productQuantity = int.Parse(Console.ReadLine());

    Product products = new Product(productName, productPrice);

    OrderItem orderItems = new OrderItem(productQuantity, productPrice, products);

    order.AddItem(orderItems);
}
System.Console.WriteLine();

System.Console.WriteLine(order);

