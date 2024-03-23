namespace DeviceProduction
{
    public class SansungFactory : IDeviceFactory
    {
        public Laptop CreateLaptop(string model, double price, bool hasNumericKeypad, bool hasSSD, double weightKg)
        {
            return new BalaxyBook("Sansung", model, price, hasNumericKeypad, hasSSD, weightKg);
        }

        public Smartphone CreatePhone(string model, double price, bool hasFingerprintScanner, bool hasNFC, string processorModel, bool is5GCapable)
        {
            return new Balaxy("Sansung", model, price, hasFingerprintScanner, hasNFC, processorModel, is5GCapable);
        }

        public Tablet CreateTablet(string model, double price, int ramGB, int storageGB)
        {
            return new BalaxyTab("Sansung", model, price, ramGB, storageGB);
        }
    }
}
