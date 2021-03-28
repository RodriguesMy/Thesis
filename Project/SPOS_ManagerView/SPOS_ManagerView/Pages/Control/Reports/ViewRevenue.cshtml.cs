using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SPOS_ManagerView.Classes;

namespace SPOS_ManagerView.Pages.Control.Reports
{
    public class ViewRevenueModel : PageModel
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
            FileName = "Revenue_Results.csv";
            FileContents = Requests.getRevenue(From, To, ref successMessage, ref errorMessage);
            ErrorMessage = errorMessage; SuccessMessage = successMessage;

            return Page();
        }
    }
}
