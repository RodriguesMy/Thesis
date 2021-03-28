using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace SPOS_ManagerView.Pages.Control
{
    public class IndexModel : PageModel
    {
        public ActionResult OnGet()
        {
            if (HttpContext.Session.GetString("username") == null)
                return Redirect("/logout");
            return Page();
        }
    }
}
