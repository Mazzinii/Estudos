
using System.Globalization;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using Pedidos.Entities.Enums;
namespace Pedidos
{
    public class Order
    {
        public DateTime Moment { get; set; }
        public OrderStatus Status { get; set; }
        public  Client Client { get; set; }
        public List<OrderItem> Items  { get; set; } = new List<OrderItem>();

        // Constructors
        public Order()
        {

        }

        public Order(DateTime moment,OrderStatus status, Client client)
        {
            Moment = moment;
            Status = status;
            Client = client;
        }

        // Metodo para adicionar item na lista
        public void AddItem(OrderItem item)
        {
            Items.Add(item);
        }

        // Metodo para remover item da lista 
        public void RemoveItem(OrderItem item)
        {
            Items.Remove(item);
        }

        // Metodo para calcular o total dos itens
        public double Total()
        {
           double sum = 0;

           foreach (OrderItem item in Items)
           {
               sum+=item.SubTotal();
           }
           return sum; 
        }
        
        // Metodo ToString()
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("ORDER SUMARY:");
            sb.Append("Order moment: ");
            sb.AppendLine(Moment.ToString("dd/MM/yyyy hh:MM:ss"));
            sb.Append("Order status: ");
            sb.AppendLine(Status.ToString());
            sb.Append("Client: ");
            sb.Append(Client.Name);
            sb.Append($"({Client.Date.ToString("dd/MM/yyyy")}) - ");
            sb.AppendLine(Client.Email);
            sb.AppendLine("Order itens:");
            
            foreach (OrderItem item in Items){
               sb.Append(item.ToString());
               
            }
            sb.Append("Total price: $");
            sb.Append(Total().ToString("F2", CultureInfo.InvariantCulture));

            return sb.ToString();
        }
        

    }
}