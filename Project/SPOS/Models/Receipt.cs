using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SPOS.Models
{
    public class Receipt
    {
        public string id { get; set; }
        public string description { get; set; }
        public string price { get; set; }
        public string qty { get; set; }
    }
}
