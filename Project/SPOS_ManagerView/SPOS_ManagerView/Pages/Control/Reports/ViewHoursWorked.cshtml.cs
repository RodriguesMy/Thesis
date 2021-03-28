using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SPOS_ManagerView.Classes;
using SPOS_ManagerView.Models;

namespace SPOS_ManagerView.Pages.Control.Reports
{
    public class ViewHoursWorkedModel : PageModel
    {
        [BindProperty]
        public DateTime From { get; set; }
        [BindProperty]
        public DateTime To { get; set; }
        public List<User> results = new List<User>();
        #region Output Messages
        public string ErrorMessage { get; set; }
        public string SuccessMessage { get; set; }
        #endregion
        #region File
        public string FileName { get; set; }
        public string FileContents { get; set; }
        #endregion
        public void fillFile(List<User> users)
        {
            FileContents = $"ID,Name,,,Hours Worked,Salary\n";
            foreach (User user in users)
            {
                double working_hours = (double)user.working_minutes / 60;
                double salary = working_hours* double.Parse(user.salary_per_hour);
                FileContents += $"{user.personal_id},{user.FName},{user.MName},{user.LName},{working_hours.ToString("N2")},{salary.ToString("N2")}\n";
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
            FileName = "Working_Hours_Results.csv";
            results = Requests.getWorkingMinutes(From, To, ref successMessage, ref errorMessage);
            ErrorMessage = errorMessage; SuccessMessage = successMessage;

            if (string.IsNullOrEmpty(ErrorMessage)) {
                fillFile(results);
            }

            return Page();
        }
    }
}
