using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Rest.Models
{
    public class ItemCategory
    {
        public int item_category { get; set; }
        public string category_name { get; set; }

        public ItemCategory(int item_category, string category_name)
        {
            this.item_category = item_category;
            this.category_name = category_name;
        }
    }
}
