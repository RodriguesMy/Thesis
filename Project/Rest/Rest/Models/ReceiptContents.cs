using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Rest.Models
{
    public class ReceiptContents
    {
        public string id { get; set; }
        public string description { get; set; }
        public string price { get; set; }
        public string qty { get; set; }

        public ReceiptContents(string item_id, string name, string price, string qty)
        {
            id = item_id;
            description = name;
            this.price = price;
            this.qty = qty;
        }
    }
}
