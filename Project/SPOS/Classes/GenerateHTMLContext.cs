using SPOS.Models;
using System.Collections.Generic;

namespace SPOS.Classes
{
    public static class GenerateHTMLContext
    {
        public static string GenerateMenuHTMLContextForCategoriesAndTypes(List<ItemType> item_types, List<ItemCategory> item_categories)
        {
            string context = "";
            foreach (var category in item_categories)
            {
                context += "<header>" + category.category_name + "</header>";

                foreach (var type in item_types)
                {
                    if(category.item_category == type.type_category)
                        context += "<button type=\"submit\" name=\""+type.type_name.Trim()+"\" onclick=\"update('"+type.type_name.Trim()+"')\">" + type.type_name.Trim() + "</button>";
                }
                context += "<br/><hr/><br/>";
            }
            return context;
        }

        public static string GenerateMenuHTMLContextForItems(List<Item> items)
        {
            string context = "";
            foreach (var item in items)
            {
                    context += "<button name=\"" + item.name.Trim() + "\" onclick=\"addToReceipt('" + item.name.Trim()+"',"+item.ID+","+item.price + ")\">" + item.name.Trim() + "</button>";
            }
            return context;
        }
    }
}
