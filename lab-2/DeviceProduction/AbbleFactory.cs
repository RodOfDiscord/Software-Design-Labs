using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeviceProduction
{
    public class AbbleFactory : IDeviceFactory
    {
        public Laptop CreateLaptop(string model, double price, bool hasNumericKeypad, bool hasSSD, double weightKg)
        {
            return new MagBook("Abble", model, price, hasNumericKeypad, hasSSD, weightKg);
        }

        public Smartphone CreatePhone(string model, double price, bool hasFingerprintScanner, bool hasNFC, string processorModel, bool is5GCapable)
        {
            return new IProne("Abble", model, price, hasFingerprintScanner, hasNFC, processorModel, is5GCapable);
        }

        public Tablet CreateTablet(string model, double price, int ramGB, int storageGB)
        {
            return new IPad("Abble", model, price, ramGB, storageGB);
        }
    }
}
