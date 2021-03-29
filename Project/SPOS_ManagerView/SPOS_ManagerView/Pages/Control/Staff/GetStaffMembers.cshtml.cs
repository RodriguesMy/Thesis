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
    public class GetStaffMembersModel : PageModel
    {
        public List<User> staff = new List<User>();
        #region Output Messages
        public string ErrorMessage { get; set; }
        public string SuccessMessage { get; set; }
        #endregion
        #region File
        public string FileName { get; set; }
        public string FileContents { get; set; }
        #endregion
        public void fillFile(List<User> staff)
        {
            FileContents = $"ID,Name,,,Personal ID,Address #,Postal Code,Address St.,Gender,Email,DOB,Salary per hour,Phone #,is_active,is_manager\n\n";

            foreach(User user in staff)
            {
                FileContents += $"{user.ID},{user.FName},{user.MName},{user.LName},{user.personal_id},{user.address_no},{user.postal_code},{user.address_street},{user.gender},{user.email},{user.DOB.ToString("yyyy-MM-dd")},EUR {(double.Parse(user.salary_per_hour)).ToString("N2")}" +
                    $",{user.phone_no},{user.is_active},{user.is_manager}\n";
            }
        }
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
            staff =  Requests.getAllStaff(ref successMessage, ref errorMessage);
            ErrorMessage = errorMessage; SuccessMessage = successMessage;

            if (string.IsNullOrEmpty(ErrorMessage))
            {
                FileName = "Staff_Data.csv";
                fillFile(staff);
            }

            return Page();
        }
    }
}
