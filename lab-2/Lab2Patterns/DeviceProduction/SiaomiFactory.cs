namespace DeviceProduction
{
    public class SiaomiFactory : IDeviceFactory
    {
        public Laptop CreateLaptop(string model, double price, bool hasNumericKeypad, bool hasSSD, double weightKg)
        {
            return new RedmiBook("Siaomi", model, price, hasNumericKeypad, hasSSD, weightKg);
        }

        public Smartphone CreatePhone(
                             string model,
                             double price,
                             bool hasFingerprintScanner,
                             bool hasNFC,
                             string processorModel,
                             bool is5GCapable)
        {
            return new Siaomi("Siaomi", model, price, hasFingerprintScanner, hasNFC, processorModel, is5GCapable);
        }

        public Tablet CreateTablet(string model, double price, int ramGB, int storageGB)
        {
            return new MiPad("Siaomi", model, price, ramGB, storageGB);
        }
    }
}
