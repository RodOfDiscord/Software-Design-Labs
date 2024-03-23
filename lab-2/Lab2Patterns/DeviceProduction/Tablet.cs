namespace DeviceProduction
{
    public abstract class Tablet
    {
        public string Brand { get; }
        public string Model { get; }
        public int RamGB { get; set; }
        public int StorageGB { get; set; }
        public double Price {  get; set; }

        protected Tablet(string brand, string model, double price, int ramGB, int storageGB)
        {
            Price = price;
            Brand = brand;
            Model = model;           
            RamGB = ramGB;
            StorageGB = storageGB;
        }

        public string GetInfo()
        {
            string info = $"Brand: {Brand},\nModel: {Model},\nPrice: {Price},\nRAM: {RamGB}GB,\nStorage: {StorageGB}GB";
            return info;
        }
    }
}
