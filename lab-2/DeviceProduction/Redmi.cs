namespace DeviceProduction
{
    internal class Redmi : Smartphone
    {
        public Redmi(string brand, string model, double price, bool hasFingerprintScanner, bool hasNFC, string processorModel, bool is5GCapable)
                     : base(brand, model, price, hasFingerprintScanner, hasNFC, processorModel, is5GCapable)
        {
        }
    }
}
