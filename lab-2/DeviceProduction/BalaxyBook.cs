using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeviceProduction
{
    public class BalaxyBook : Laptop
    {
        public BalaxyBook(string brand, string model, double price, bool hasNumericKeypad, bool hasSSD, double weightKg) : base(brand, model, price, hasNumericKeypad, hasSSD, weightKg)
        {
        }
    }
}
