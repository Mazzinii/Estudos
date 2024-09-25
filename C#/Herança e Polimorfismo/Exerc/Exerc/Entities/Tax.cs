

namespace Exerc.Entities
{
    abstract class Tax
    {
        public string Name { get; set; }
        public double AnualIncome { get; set; }

        public Tax(){

        }

        public Tax(string name, double anualincome){
            Name = name;
            AnualIncome = anualincome;
        }
        
        public abstract double TaxCalc();
        
    }
}