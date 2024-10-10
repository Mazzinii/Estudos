
using System.Data.Common;
using System.Globalization;
using System.Net.Mail;

namespace Interface.Entities
{
    public class Installment
    {
       public DateTime Duedate { get; set; }
       public double Amount { get; set; } 
    

        public Installment(DateTime duedate, double amount){
            Duedate = duedate;
            Amount = amount;
        }

        override public string ToString(){
            return Duedate.ToString("dd/MM/yyyy") 
            + " - " 
            + Amount.ToString("F2", CultureInfo.InvariantCulture);
        }
    
    }
}