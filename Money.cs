using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача_01_02
{
    public class Money
    {
        public string Currency { get; set;}
        public int Dollars { get; set; }
        public int Cents { get; set; }

        public Money(string currency, int dollars, int cents)
        {
            Currency = currency;
            Dollars = dollars;
            Cents = cents;
        }
                
        public virtual string GetPrice()
        {
            return string.Format("{0} {1:d} {2:d}", Currency, Dollars, Cents);
        }
    }
}
