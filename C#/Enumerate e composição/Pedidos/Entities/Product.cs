

namespace Pedidos
{
    public class Product
    {
        public required string Name { get; set; }
        public required double Price { get; set; }

        public Product()
        {

        }

        public Product(string name, double price)
        {
            Name = name;
            Price = price;
        }

    }
}