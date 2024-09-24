using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Herança.Entities
{
    public class ImportedProduct : Product
    {
        public double CustomsFee { get; set; }

        public ImportedProduct(){

        }

         public ImportedProduct(string name, double price, double customsfee)
         : base(name, price)
         {
            CustomsFee = customsfee;
         }

         public Double TotalPrice()
         {
            return Price + CustomsFee;
         }

        public override string PriceTag()
        {
            return Name + " $ " + TotalPrice().ToString("F2") + $" (Customs fee: $ {CustomsFee})";
        }
    }
}