

namespace Exerc.Entities
{
     class PhysicsTax : Tax
    {
        public double HealthExpend { get; set; }


        public PhysicsTax(){

        }

        public PhysicsTax(string name, double anualincome, double healthexpend)
        :base(name, anualincome)
        {
            HealthExpend = healthexpend;
        }

        public override double TaxCalc()
        {   
            double taxHealth = 0;
            if (HealthExpend > 0){
                 taxHealth = HealthExpend * 0.50;
            }
            if(AnualIncome > 20000){
                return AnualIncome * 0.25 - taxHealth;
            }else {
                return AnualIncome * 0.15 - taxHealth;
            }
        }

        public override string ToString()
        {
            return $"{Name}: $ {TaxCalc():F2}";
        }
    }
}