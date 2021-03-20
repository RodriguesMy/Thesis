using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Newtonsoft.Json;
using SPOS.Models;
using System.Collections.Generic;

namespace SPOS.Pages
{
    public class PaymentModel : PageModel
    {
        [BindProperty]
        public string CashReceived { get; set; }
        [BindProperty]
        public string Total { get; set; }
        [BindProperty]
        public string ReceiptContents { get; set; }
        [BindProperty]
        public string PaymentMethod { get; set; }
        List<Receipt> receipt = new List<Receipt>();
        public void OnGet(){}

        public ActionResult OnPost()
        {
            double change = 0;
            if (PaymentMethod.Equals("CASH"))
            {
                change = double.Parse(CashReceived) - double.Parse(Total);
                //if the change is a negative number, something is wrong, so return same page and refuse to close the order
                if (change < 0) return Page();
            }
            HttpContext.Session.SetString("change", change.ToString());

            //receive order
            receipt = JsonConvert.DeserializeObject<List<Receipt>>(ReceiptContents);

            //send order to database
            Requests.Requests.SendOrder(receipt);

            //insert order to the database
            return Redirect("./EndPage"); //move to endpage
        }
    }
}
