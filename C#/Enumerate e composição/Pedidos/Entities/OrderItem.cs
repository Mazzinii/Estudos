
using System.Globalization;
using System.Text;

namespace Pedidos
{
    public class OrderItem
    {
        public int Quantity { get; set; }
        public double Price { get; set; }
        public  Product Product { get; set; }

        public OrderItem()
        {

        }
        
        public OrderItem(int quantity, double price, Product product)
        {
            Quantity = quantity;
            Price = price;
            Product = product;
        }

        public double SubTotal()
        {
            return Quantity * Price;
        }

        override public string ToString()
        {
            StringBuilder sb = new StringBuilder();

             sb.Append(Product.Name);
                sb.Append(", ");
                sb.Append(Price.ToString("F2", CultureInfo.InvariantCulture));
                sb.Append(", ");
                sb.Append("Quantity: ");
                sb.Append(Quantity);
                sb.Append(", ");
                sb.Append("Subtotal: $");
                sb.AppendLine(SubTotal().ToString("F2", CultureInfo.InvariantCulture));
                
                

                return  sb.ToString();
        }
        
    }
}