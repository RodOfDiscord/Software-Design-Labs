namespace DeviceProduction
{
    public interface IDeviceFactory
    {
        public abstract Smartphone CreatePhone(string model,
                                               double price,
                                               bool hasFingerprintScanner,
                                               bool hasNFC,
                                               string processorModel,
                                               bool is5GCapable);

        public abstract Tablet CreateTablet(string model,
                                            double price,
                                            int ramGB,
                                            int storageGB);

        public abstract Laptop CreateLaptop(string model,
                                            double price,
                                            bool hasNumericKeypad,
                                            bool hasSSD,
                                            double weightKg);
    }
}
