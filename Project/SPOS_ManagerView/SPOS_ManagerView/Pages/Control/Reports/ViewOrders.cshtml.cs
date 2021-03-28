using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SPOS_ManagerView.Classes;
using SPOS_ManagerView.Models;

namespace SPOS_ManagerView.Pages.Control.Reports
{
    public class ViewOrdersModel : PageModel
    {
        [BindProperty]
        public DateTime From { get; set; }
        [BindProperty]
        public DateTime To { get; set; }

        #region Output Messages
        public string ErrorMessage { get; set; }
        public string SuccessMessage { get; set; }
        #endregion
        #region File
        public string FileName { get; set; }
        public string FileContents { get; set; }
        #endregion
        public void fillFile(Dictionary<long, List<Order>> orders)
        {
            FileContents = $"ID,Datetime Created,Datetime Updated,Payment Method,Discount,,Item Name,Qty,Price,Total\n\n";

            foreach (var order in orders)
            {
                double total = 0;
                FileContents += $"{order.Key},{order.Value[0].datetime_created},{order.Value[0].datetime_updated},{order.Value[0].payment_method.Trim()},%{order.Value[0].discount_applied}\n";
                foreach (var content in order.Value)
                {
                    total += Convert.ToDouble(content.total);
                    double price = Convert.ToDouble(content.total);
                    FileContents += $",,,,,,{content.item_name.Trim()},{content.qty},EUR {price.ToString("N2")}\n";
                }
                FileContents += $",,,,,,,,,EUR {total.ToString("N2")}\n";
            }
        }
        public ActionResult OnGet()
        {
            if (HttpContext.Session.GetString("username") == null)
                return Redirect("/logout");

            return Page();
        }
        public ActionResult OnPost()
        {
            string successMessage = "";
            string errorMessage = "";
            FileName = "Orders_Results.csv";
            Dictionary<long, List<Order>> orders = Requests.getOrders(From, To, ref successMessage, ref errorMessage);
            ErrorMessage = errorMessage; SuccessMessage = successMessage;

            if (string.IsNullOrEmpty(ErrorMessage))
            {
                fillFile(orders);
            }
            return Page();
        }
    }
}
