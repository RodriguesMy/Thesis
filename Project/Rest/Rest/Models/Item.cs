using System;

namespace Rest.Models
{
    public class Item
    {
        public int ID { get; set; }
        public string name { get; set; }
        public Decimal price { get; set; }
        public int item_type { get; set; }
        public int item_category { get; set; }

        public Item(int ID, string name, Decimal price, int item_type,int item_category)
        {
            this.ID = ID;
            this.name = name;
            this.price = price;
            this.item_type = item_type;
            this.item_category = item_category;
        }
    }
}
