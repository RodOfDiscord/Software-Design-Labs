using Warehouse.Contracts;

namespace Warehouse
{
    public class WindowReporting
    {
        IReporting reporting;

        public WindowReporting(IReporting reporting)
        {
            this.reporting = reporting;
        }

        public void ShowReceiptInvoice(List<Warehouse> products)
        {
            // ...
        }

        public void ShowExpenseInvoice(List<Warehouse> products)
        {
            // ...
        }

        public void ShowInventoryReport(List<Warehouse> products)
        {
            // ...
        }
    }
}
