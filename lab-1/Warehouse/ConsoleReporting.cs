using Warehouse.Contracts;

namespace Warehouse
{
    public class ConsoleReporting
    {
        public IReporting Reporting {get; private set; }
        public ConsoleReporting(IReporting reporting) {
            Reporting = reporting;
        }

        public void PrintReceiptInvoice(List<Warehouse> products)
        {
            Console.WriteLine(Reporting.GetReceiptInvoice(products));
        }

        public void PrintExpenseInvoice(List<Warehouse> products)
        {
            Console.WriteLine(Reporting.GetReceiptInvoice(products));
        }

        public void PrintInventoryReport(List<Warehouse> products)
        {
            Console.WriteLine(Reporting.GetReceiptInvoice(products));
        }
    }
}
