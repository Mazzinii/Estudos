using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;

namespace Generics.Entities
{
    public class Product : IComparable
    {
        public string Name { get; set; }
        public double Price { get; set; }

        public Product(){

        }

        public Product(string name, double price){
            Name = name;
            Price = price;
        }

        override public string ToString(){
            return Name + ", " + Price.ToString("F2", CultureInfo.InvariantCulture);
        }

        //implementando a inteface IComparable
        public int CompareTo(object? obj)
        {   
            //verificando se o parametro é um product
            if(!(obj is Product)){
                throw new ArgumentException("Comparing error: argument has to be a Product");
            }
            //comparando o atributo Price
            Product other = obj as Product;
            return Price.CompareTo(other.Price);

        }
    }
}