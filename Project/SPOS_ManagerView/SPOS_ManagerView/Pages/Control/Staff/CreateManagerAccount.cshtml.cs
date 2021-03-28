using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SPOS_ManagerView.Classes;

namespace SPOS_ManagerView.Pages.Control.Staff
{
    public class CreateManagerAccountModel : PageModel
    {
        [BindProperty]
        public string Personal_Id { get; set; }
        [BindProperty]
        public string Username { get; set; }
        [BindProperty]
        public string Password { get; set; }
        #region Output Messages
        public string ErrorMessage { get; set; }
        public string SuccessMessage { get; set; }
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

            Requests.createManagerAccount(Personal_Id,Username, StaticFunctions.GetHash(Password), ref successMessage, ref errorMessage);
            ErrorMessage = errorMessage; SuccessMessage = successMessage;

            return Page();
        }
    }
}
