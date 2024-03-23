using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeviceProduction
{
    public class RedmiBook : Laptop
    {
        public RedmiBook(string brand, string model, double price, bool hasNumericKeypad, bool hasSSD, double weightKg) 
                       : base(brand, model, price, hasNumericKeypad, hasSSD, weightKg)
        {
        }
    }
}
