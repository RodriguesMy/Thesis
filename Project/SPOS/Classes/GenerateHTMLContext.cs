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

        public static string GenerateMenuHTMLContextForUserCheckInOut(Dictionary<int, string> users, bool checkIn)
        {
            char check_in_value = checkIn ? '1' : '0'; //if the user is checked in, their saved value is 1
            string context = "";
            foreach (var user in users)
            {
                context += $"<button class=\"userBtn\" onclick=\"openModalForPassCode('{user.Key}','{check_in_value}')\">{user.Value}</button>";
            }
            return context;
        }

        public static string GenerateMenuHTMLContextForTodaysOrders(Dictionary<int,decimal> orders)
        {
            string context = "";
            foreach (var order in orders)
            {
                context += $"<button class=\"receiptBtn\" onclick=\"retrieveOrder('{order.Key}')\">{order.Key} <br /> €{order.Value.ToString("N2")}</button>";
            }
            return context;
        }
    }
}
