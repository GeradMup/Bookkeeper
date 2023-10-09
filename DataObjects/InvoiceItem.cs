using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Invoices.src.DataObjects
{
    public class InvoiceItem
    {
        public InvoiceItem(string name, decimal quantity, decimal unitPrice)
        {
            this.Name = name;
            this.Quantity = quantity;
            this.UnitPrice = unitPrice;
            this.TotalPrice = quantity * unitPrice;
        }

        public string Name { get; set; }
        public decimal Quantity { get; set; }
        public decimal UnitPrice { get; set; }
        public decimal TotalPrice { get; set; }

        public void recalculateTotalPrice()
        {
            this.TotalPrice = this.Quantity * this.UnitPrice;
        }

        public List<string> invoiceItemToList()
        {
            List<string> itemList = new List<string>();
            itemList.Add(this.Name);
            itemList.Add(this.Quantity.ToString());
            itemList.Add(this.UnitPrice.ToString());
            itemList.Add(this.TotalPrice.ToString());
            return itemList;
        }
    }
}
