using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeviceProduction
{
    public class MiPad : Tablet
    {
        public MiPad(string brand, string model, double price, int ramGB, int storageGB) : base(brand, model, price, ramGB, storageGB)
        {
        }
    }
}
