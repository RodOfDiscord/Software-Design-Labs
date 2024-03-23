namespace DeviceProduction
{
    public abstract class Smartphone
    {
        protected Smartphone(string brand,
                             string model,                            
                             double price,
                             bool hasFingerprintScanner,
                             bool hasNFC,
                             string processorModel,
                             bool is5GCapable)
        {
            Brand = brand;
            Model = model;           
            Price = price;
            HasFingerprintScanner = hasFingerprintScanner;
            HasNFC = hasNFC;
            ProcessorModel = processorModel;
            Is5GCapable = is5GCapable;
        }

        public string Brand { get; set; }
        public string Model { get; set; }
        public double Price {  get; set; }
        public bool HasFingerprintScanner { get; set; }
        public bool HasNFC { get; set; }
        public string ProcessorModel { get; set; }
        public bool Is5GCapable { get; set; }

        public string GetInfo()
        {
            string info = $"Brand: {Brand}, \nModel: {Model}, \nPrice: {Price}, \nHas Fingerprint Scanner: {HasFingerprintScanner}, " +
                          $"\nHas NFC: {HasNFC}, \nProcessor Model: {ProcessorModel}, \nIs 5G Capable: {Is5GCapable}";
            return info;
        }
    }
}
