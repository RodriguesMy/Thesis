using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace SPOS_ManagerView.Pages
{
    public class LogOutModel : PageModel
    {
        public ActionResult OnGet()
        {
            HttpContext.Session.Clear();
            return Redirect("/");
        }
    }
}
