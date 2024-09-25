
namespace Exerc.Entities
{
     class JuridicTax : Tax
    {
        public int Employees { get; set; }

        public JuridicTax(){

        }

        public JuridicTax(string name, double anualincome, int employees)
        : base(name, anualincome)
        {
            Employees = employees;
        }

        public override double TaxCalc()
        {   
            if (Employees <= 10){
                return AnualIncome * 0.16;
            }else{
                return AnualIncome * 0.14;
            }
        }

        public override string ToString()
        {
            return $"{Name}: $ {TaxCalc():F2}";
        }
    }
}