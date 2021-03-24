using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Newtonsoft.Json;
using SPOS.Classes;
using SPOS.Models;

namespace SPOS.Pages
{
    public class ModifyExistingOrdersModel : PageModel
    {        
        [BindProperty]
        public string selectedOrderId { get; set; }
        Dictionary<int, decimal> todaysOrders = new Dictionary<int, decimal>();
        public string todaysOrdersHtmlContext { get; set; }
        public string jsonReceipt { get; set; }

        protected void updateFields()
        {
            todaysOrders = Requests.Requests.getTodaysOrders();
            todaysOrdersHtmlContext = GenerateHTMLContext.GenerateMenuHTMLContextForTodaysOrders(todaysOrders); ;
        }
        public ActionResult OnGet()
        {
            try
            {
                int.Parse(HttpContext.Session.GetString("userId"));
            }
            catch (Exception e)
            {
                return Redirect("/");
            }

            updateFields();
            return Page();
        }

        public ActionResult OnPost()
        {
            jsonReceipt = JsonConvert.SerializeObject(Requests.Requests.getOrder(selectedOrderId));
            updateFields();
            return Page();
        }
    }
}
