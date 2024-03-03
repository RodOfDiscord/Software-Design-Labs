using System.Collections.Generic;
using Warehouse.Contracts;
using Warehouse.Currency;

namespace Warehouse
{
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

        private decimal GetTotalPrice(List<Warehouse> products)
        {
            decimal total = 0 ;
            foreach (Warehouse product in products)
            {
                decimal price = Product.GetPriceByCurrencySymbol(product, currencySymbol) ?.GetFullValue() ?? 0;
                total +=  price * (decimal)product.Quantity;
            }               
            return total;           
        }
        
    }
}
