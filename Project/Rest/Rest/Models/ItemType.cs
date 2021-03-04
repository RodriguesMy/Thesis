using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Rest.Models
{
    public class ItemType
    {
        public int type_id { get; set; }
        public string type_name { get; set; }

        public ItemType(int type_id,string type_name)
        {
            this.type_id = type_id;
            this.type_name = type_name;
        }
    }
}
