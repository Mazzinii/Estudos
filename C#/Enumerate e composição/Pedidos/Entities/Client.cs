

namespace Pedidos
{
    public class Client
    {
        public required string Name  { get; set; }
        public required string Email { get; set; }
        public DateTime Date { get; set; } 

        public Client()
        {

        }
        public Client(string name, string email, DateTime date)
        {
            Name = name;
            Email = email;
            Date = date;

        }

    }
}