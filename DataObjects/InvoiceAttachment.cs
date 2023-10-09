using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Invoices.src.DataObjects
{
    public class InvoiceAttachement
    {
        public InvoiceAttachement(string attachmentPath, string name) =>
            (Path, Attachment) = (attachmentPath, name);

        public string Path { get; }
        public string Attachment { get; }
    }
}
