using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeviceProduction
{
    public class IProne : Smartphone
    {
        public IProne(string brand, string model, double price, bool hasFingerprintScanner, bool hasNFC, string processorModel, bool is5GCapable) : base(brand, model, price, hasFingerprintScanner, hasNFC, processorModel, is5GCapable)
        {
        }
    }
}
