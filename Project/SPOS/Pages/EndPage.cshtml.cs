using System;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace SPOS.Pages
{
    public class EndPageModel : PageModel
    {
        public string change { get; set; }
        public ActionResult OnGet(){
            try
            {
                change = @String.Format("{0:C}", Convert.ToDouble(HttpContext.Session.GetString("change")));

                //kill session
                HttpContext.Session.Clear();

            }
            catch (Exception e)
            {
                return Redirect("/");
            }

            return Page();
        }
    }
}
