using DeviceProduction;
AbbleFactory factory = new AbbleFactory();

clientMethod(factory);

static void clientMethod(IDeviceFactory factory)
{
    Laptop laptop = factory.CreateLaptop("ProBook X1000", 1200.0, true, true, 1.5);

    Smartphone phone = factory.CreatePhone("DA245D5A45", 1999.0, true, true, "Snapdragon 8 Gen 2", true);

    Tablet tablet = factory.CreateTablet("Tab10000", 699.0, 8, 128);

    Console.WriteLine(laptop.GetInfo());
    Console.WriteLine("-------------------------------------");
    Console.WriteLine(phone.GetInfo());
    Console.WriteLine("-------------------------------------");
    Console.WriteLine(tablet.GetInfo());
}