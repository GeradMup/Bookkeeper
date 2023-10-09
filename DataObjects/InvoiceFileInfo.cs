using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Invoices.src.DataObjects
{
    public class InvoiceFileInfo
    {
        public InvoiceFileInfo(DateTime date, string company, string number)
        {
            (Date, Company, Number) = (date, company, number);
        }

        public DateTime Date { get; }
        public string Company { get; }
        public string Number { get; }
    }
}
