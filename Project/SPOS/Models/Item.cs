using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SPOS.Models
{
    public class Item
    {
        public int ID { get; set; }
        public string name { get; set; }
        public Decimal price { get; set; }
        public int item_type { get; set; }
        public int item_category { get; set; }
    }
}
