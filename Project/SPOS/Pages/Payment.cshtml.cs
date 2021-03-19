using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace SPOS.Pages
{
    public class PaymentModel : PageModel
    {
        [BindProperty]
        public string CashReceived { get; set; }
        [BindProperty]
        public string Total { get; set; }
        public void OnGet(){}

        public ActionResult OnPost()
        {
            double change = double.Parse(CashReceived) - double.Parse(Total);

            HttpContext.Session.SetString("change", change.ToString());
            return Redirect("./EndPage"); //direct to main page
            //receive order
            //insert order to the database
            //move to endpage
        }
    }
}
