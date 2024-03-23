namespace DeviceProduction
{
    public abstract class Laptop
    {
        protected Laptop(string brand, string model, double price, bool hasNumericKeypad, bool hasSSD, double weightKg)
        {
            Brand = brand;
            Model = model;
            Price = price;
            HasNumericKeypad = hasNumericKeypad;
            HasSSD = hasSSD;
            WeightKg = weightKg;
        }

        public string Brand { get; set; }
        public string Model { get; set; }
        public double Price { get; set; }
        public bool HasNumericKeypad { get; set; } 
        public bool HasSSD { get; set; } 
        public double WeightKg { get; set; } 

        public string GetInfo()
        {
            string info = $"Brand: {Brand},\nModel: {Model},\nPrice: {Price},\nHas Numeric Keypad: {HasNumericKeypad},\nHas SSD: {HasSSD},\nWeight: {WeightKg}kg";
            return info;
        }
    }
}
