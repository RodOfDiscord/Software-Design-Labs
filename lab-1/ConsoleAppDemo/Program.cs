using Warehouse;
using Warehouse.Currency;

Category builingMaterials = new("Builing materials");

// test data
var cement = new Warehouse.Warehouse([new Money(1000,50, new Dollar()), new Money(4654, 50, new Hryvnia())], "Cement", 500, "kg", DateTime.Now, builingMaterials);
var bricks = new Warehouse.Warehouse([new Money(500,60, new Dollar()), new Money(1000, 50, new Hryvnia())], "Bricks", 1000, "pcs", DateTime.Now, builingMaterials);
var steel = new Warehouse.Warehouse([new Money(1500,5 , new Dollar()), new Money(4654, 50, new Hryvnia())], "Steel", 800, "kg", DateTime.Now, builingMaterials);

PrintProductDollar(cement);
Product.IncreasePrice(cement,new Money(200,0 ,new Dollar()));
PrintProductDollar(cement);

StartWork(new Manager("manager1", "test"));

List<Warehouse.Warehouse> prods = [cement, bricks, steel];

Reporting reporting = new("USD");
ConsoleReporting consoleReporting = new(reporting);

consoleReporting.PrintInventoryReport(prods);
reporting.ChangeCurrencySymbol("UAH");
consoleReporting.PrintExpenseInvoice(prods);

void PrintProductDollar(Warehouse.Warehouse product)
{
    Console.WriteLine($"{product.Name} price: " + Product.GetPriceByCurrencySymbol(product,"USD")?.GetFullValue());
}

void StartWork(Worker worker)
{
    Console.WriteLine(worker.DoWork() ? $"{worker.FirstName} done his work" : "error during the work");
}