# Lab. №1

## Content

- [SOLID](#solid)
  - [Single Responsibility](#single-responsibility)
  - [Open for Extension Closed for Modification](#open-for-extension-closed-for-modification)
  - [Liskov Substitution](#liskov-substitution)
  - [Interface Segregation](#interface-segregation)
  - [Dependency Inversion](#dependency-inversion)
- [DRY](#dry)
- [Composition Over Inheritance](#composition-over-inheritance)

## SOLID

### Single Responsibility

[Product](./Warehouse\Product.cs) responsible for manipulating price and getting value from object.

```c#
public static class Product
{
    public static void DecreasePrice(Warehouse product,Money val)
    {
        var priceToChange = product.Prices.FirstOrDefault(price => price.Currency.Symbol == val.Currency.Symbol);
        if (priceToChange != null)
        {
            priceToChange.SetAmount(priceToChange.GetAmount() - (int)val.GetFullValue());
            priceToChange.SetCents(priceToChange.GetCents() - (int)(val.GetFullValue() % 1 * 100));
        }
    }

    //...

    public static Money? GetPriceByCurrencySymbol(Warehouse product, string symbol)
    {
        var price = product.Prices.FirstOrDefault(p => p.Currency.Symbol == symbol);
        return price;
    }
}

```

### Open for Extension Closed for Modification

To add new currency you simply need to add new class which is inherited from [Currency](./Warehouse/Currency/Currency.cs)

```c#
public abstract class Currency
{
    public string Symbol { get; private set; }
    public string Name { get; private set; }

    protected Currency(string symbol, string name)
    {
        Symbol = symbol;
        Name = name;
    }
}

public class Dollar : Currency
{
    public Dollar() : base("USD", "Dollar")
    {
    }
}

public class Euro : Currency
{
    public Euro() : base("EUR", "Euro")
    {
    }
}
```

### Liskov Substitution

[Worker](./Warehouse/Worker.cs) has base logic for child classes, like [Manager](./Warehouse/Manager.cs), which can override methods for specific realization

```c#
public class Worker
{
    public string FirstName { get; set; }
    public string LastName { get; set; }

    public  Worker(string firstName, string lastName)
    {
        FirstName = firstName;
        LastName = lastName;
    }

    public virtual bool DoWork()
    {
        return true;
    }
}

public class Keeper : Worker
{
    public Keeper(string firstName, string lastName) : base(firstName, lastName) {}

    public override bool DoWork()
    {
        // logic
        return true;
    }
}

public class Manager : Worker
{
    public Manager(string firstName, string lastName) : base(firstName, lastName) {}

    public override bool DoWork()
    {
        // outstanding logic
        return true;
    }
}
```

### Interface Segregation

[Money](./Warehouse\Money.cs) is implementing all methods in [IMoney](./Warehouse/Contracts/IMoney.cs) interface

```c#
public interface IMoney
{
    public decimal GetFullValue();
    public void SetAmount(int amount);
    public void SetCents(int cents);
    public int GetAmount();
    public int GetCents();
}

public class Money : IMoney
{
    public int Amount;
    public int Cents;
    public Currency.Currency Currency { get; set; }
    public Money(int amount, int cents, Currency.Currency currency)
    {
        Amount = amount;
        Cents = cents;
        Currency = currency;
    }
    public decimal GetFullValue() { return (decimal) (Amount + Cents / 100.0); }

    public override string ToString()
    {
        return GetFullValue().ToString();
    }

    public void SetAmount(int amount) => Amount = amount;

    public void SetCents(int cents) => Cents = cents;

    public int GetAmount() => Amount;

    public int GetCents() => Cents;
}
```

### Dependency Inversion

[IReporting](./Warehouse/Contracts/IReporting.cs) is implemented in [Reporting](./Warehouse/Reporting.cs) and can be used in classes with different logic, for example, printing reports on a console ([ConsoleReporting](./Warehouse/ConsoleReporting.cs#L7)) or showing them in a window ([WindowReporting](./Warehouse/WindowReporting.cs#L7)).

```c#
public interface IReporting
{
    void PrintReceiptInvoice(List<Warehouse> products);
    void PrintExpenseInvoice(List<Warehouse> products);
    void PrintInventoryReport(List<Warehouse> products);
}

public class ConsoleReporting
{
    IReporting reporting;
    public ConsoleReporting(IReporting reporting)
    {
        this.reporting = reporting;
    }

    public void PrintReceiptInvoice(List<Warehouse> products)
    {
        Console.WriteLine(reporting.GetReceiptInvoice(products));
    }

    //...
}

public class WindowReporting
{
    IReporting reporting;

    public WindowReporting(IReporting reporting)
    {
        this.reporting = reporting;
    }
    // ...
}
```

## DRY

Putting common logic in a separate method to avoid duplicating code in [Reporting](./Warehouse/Reporting.cs#L35-L46)

```c#
public class Reporting : IReporting
{
    string currencySymbol;
    public Reporting(string currencySymbol)
    {
        this.currencySymbol = currencySymbol;
    }

    public void ChangeCurrencySymbol(string currencySymbol)
    {
        this.currencySymbol = currencySymbol;
    }

    public string GetExpenseInvoice(List<Warehouse> products)
    {
        return GenerateStringProducts(products);
    }

    public string GetInventoryReport(List<Warehouse> products)
    {
        return GenerateStringProducts(products);
    }

    public string GetReceiptInvoice(List<Warehouse> products)
    {
        return GenerateStringProducts(products);
    }

    private string GenerateStringProducts(List<Warehouse> products)
    {
        string res = $"{"Name",10}|{"Price",10}|{"Quantity",10}|{"Measure",10}|" +
                     $"{"Delivery Date",20}|{"Category",20}|\n";
        foreach (Warehouse product in products)
        {
            res += $"{product.Name,10}|{Product.GetPriceByCurrencySymbol(product, currencySymbol),10}|{product.Quantity,10}|" +
                   $"{product.Measure,10}|{product.DeliveryDate.Date,20}|{product.Category.Name,20}|\n";
        }
        res += "Total: " + GetTotalPrice(products);
        return res;
    }
    // ...
}
```

## Composition Over Inheritance

[Warehouse](./Warehouse/Warehouse.cs#L13) HAS-A [Category class](./Warehouse/Category.cs) and list of [Money](./Warehouse/Money.cs)

```c#
public class Warehouse
{
    //...
    public List<Money> Prices {get; set; }
    public Category Category { get; set; }
    //...
}
```
