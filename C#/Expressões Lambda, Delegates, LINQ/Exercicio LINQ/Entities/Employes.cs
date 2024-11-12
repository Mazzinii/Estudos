

namespace Exercicio_LINQ.Entities
{
    public class Employes
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public double Salary { get; set; }

        public Employes(){

        }
        
        public Employes(string name, string email, double salary){
            Name = name;
            Email = email;
            Salary = salary;
        }       
    }
}