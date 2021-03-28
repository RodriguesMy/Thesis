using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SPOS_ManagerView.Classes;
using SPOS_ManagerView.Models;

namespace SPOS_ManagerView.Pages.Control.Staff
{
    public class CreateStaffMemberModel : PageModel
    {
        [BindProperty]
        public new User user { get; set; }
        public Dictionary<int, string> jobTitles = new Dictionary<int, string>();

        #region Output Messages
        public string ErrorMessage { get; set; }
        public string SuccessMessage { get; set; }
        #endregion
        public ActionResult OnGet()
        {
            if (HttpContext.Session.GetString("username") == null)
                return Redirect("/logout");

            //retrieve job titles
            jobTitles = Requests.getJobTitles();

            return Page();
        }

        public ActionResult OnPost()
        {
            string successMessage = "";
            string errorMessage = "";
            Requests.createUser(user, ref successMessage, ref errorMessage);
            ErrorMessage = errorMessage; SuccessMessage = successMessage;

            //retrieve job titles
            jobTitles = Requests.getJobTitles();

            return Page();
        }
    }
}
