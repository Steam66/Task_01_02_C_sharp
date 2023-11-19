using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача_01_02
{
    public class Product:Money
    {
        public const int Discount = 10;
        public string Name {  get; set; }
        public Money Price {  get; set; }
        public Product(string name, Money price )
        {
            Name = name;
            Price = price;
        }
                
        public string GetName()
        {
            return Name;
        }
                
        public override string GetPrice()
        {
            return string.Format("{0} {1:d} {2:d}", Currency, Dollars, Cents);
        }

       // public decimal Price { get; set; }
        
        public void ReducePrice()
        {
            decimal newPrice = Price - (Price / 100 * Discount);
            Price = newPrice;
        }



    }
}
