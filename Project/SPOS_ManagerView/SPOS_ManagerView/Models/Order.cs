using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SPOS_ManagerView.Models
{
    public class Order
    {
        public DateTime datetime_created { get; set; }
        public DateTime datetime_updated { get; set; }
        public string payment_method { get; set; }
        public int discount_applied { get; set; }
        public string item_name { get; set; }
        public int qty { get; set; }
        public decimal total { get; set; }
    }
}
