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
    public class UpdateStaffMemberModel : PageModel
    {
        [BindProperty]
        public new User user { get; set; }
        public new User userRetrieved { get; set; }
        [BindProperty]
        public string ID { get; set; }
        public Dictionary<int, string> jobTitles = new Dictionary<int, string>();
        #region Output Messages
        public string ErrorMessage { get; set; }
        public string SuccessMessage { get; set; }
        public string DOB { get; set; }
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
            Requests.updateStaffMember(user, ref successMessage, ref errorMessage);
            ErrorMessage = errorMessage; SuccessMessage = successMessage;

            user = null;
            return Page();
        }

        public ActionResult OnPostButton()
        {
            string successMessage = "";
            string errorMessage = "";
            userRetrieved = Requests.GetUserById(ID, ref errorMessage, ref successMessage);
            ErrorMessage = errorMessage; SuccessMessage = successMessage;

            if (string.IsNullOrEmpty(ErrorMessage))
            {
                DOB = userRetrieved.DOB.ToString("yyyy-MM-dd");
            }
            else
            {
                user = null;
                userRetrieved = null;
                ErrorMessage = "User not found.";
            }

            jobTitles = Requests.getJobTitles();
            return Page();
        }
    }
}
