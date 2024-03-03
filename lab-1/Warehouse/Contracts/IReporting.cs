namespace Warehouse.Contracts
{
    public interface IReporting
    {
        string GetReceiptInvoice(List<Warehouse> products);
        string GetExpenseInvoice(List<Warehouse> products);
        string GetInventoryReport(List<Warehouse> products);
    }
}
