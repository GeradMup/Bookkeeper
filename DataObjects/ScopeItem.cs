using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Invoices.src.DataObjects
{
    public class ScopeItem
    {
        public ScopeItem(string title, string comment)
        {
            this.Title = title;
            this.Comment = comment;
        }

        public string Title { get; set; }
        public string Comment { get; set; }

        public List<string> scopeItemToList()
        {
            List<string> itemList = new List<string>();
            itemList.Add(this.Title);
            itemList.Add(this.Comment);
            return itemList;
        }
    }
}
