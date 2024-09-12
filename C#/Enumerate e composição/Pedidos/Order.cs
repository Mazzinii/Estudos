
using System.Reflection.Metadata.Ecma335;
using System.Text;
using Pedidos.Entities.Enums;
namespace Pedidos
{
    public class Order
    {
        public DateTime Moment { get; set; }
        public OrderStatus Status { get; set; }
        public required Client Client { get; set; }
        public List<OrderItem> Items  { get; set; } = new List<OrderItem>();


        public Order()
        {

        }

        public Order(DateTime moment,OrderStatus status, Client client)
        {
            Moment = moment;
            Status = status;
            Client = client;
        }

        public void AddItem(OrderItem item)
        {
            Items.Add(item);
        }

        public void RemoveItem(OrderItem item)
        {
            Items.Remove(item);
        }

        public double Total()
        {
           double sum = 0;

           foreach (OrderItem item in Items)
           {
               sum+=item.SubTotal();
           }
           return sum; 
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("ORDER SUMARY");
            sb.Append("Order moment: ");
            sb.Append(Moment.ToString("dd/MM/yyyy HH:mm:ss"));
            sb.Append("Order status: ");
            sb.AppendLine(Status.ToString());
            sb.Append("Client: ");
            sb.Append(Client.Name);
            sb.Append($"({Client.Date}) - ");
            sb.AppendLine(Client.Email);
            sb.AppendLine("Order itens:");
            
            foreach (OrderItem item in Items){
                sb.Append(item.Product.Name);
                sb.Append(", ");
                sb.Append(item.Quantity);
                sb.Append(", ");
                sb.Append("Subtotal: $");
                sb.AppendLine(item.SubTotal().ToString());
                sb.Append("Total price: $");
                sb.AppendLine(Total().ToString());
            }
            
            return sb.ToString();
        }
        

    }
}