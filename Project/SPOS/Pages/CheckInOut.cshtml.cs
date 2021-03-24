using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SPOS.Classes;

namespace SPOS.Pages
{
    public class CheckInOutModel : PageModel
    {
        [BindProperty]
        public string UserId { get; set; }
        [BindProperty]
        public string Code { get; set; }
        [BindProperty]
        public string Check_In_Value { get; set; }
        public string checkInUsersContext { get; set; }
        public string checkOutUsersContext { get; set; }

        protected void updateFields()
        {
            //get all checked in users
            Dictionary<int, string> checkedInUsers = Requests.Requests.getAllUsersByCheckIn(1);

            //get all checked out users
            Dictionary<int, string> checkedOutUsers = Requests.Requests.getAllUsersByCheckIn(0);

            //get html context
            checkInUsersContext = GenerateHTMLContext.GenerateMenuHTMLContextForUserCheckInOut(checkedInUsers,true);
            checkOutUsersContext = GenerateHTMLContext.GenerateMenuHTMLContextForUserCheckInOut(checkedOutUsers,false);
        }

        public void OnGet()
        {
            updateFields(); 
        }

        public ActionResult OnPost()
        {
            if (Requests.Requests.validateUserByIdAndPin(int.Parse(UserId), int.Parse(Code)))
            {
                if(int.Parse(Check_In_Value) == 0) //check them in
                    Requests.Requests.checkInOutUser(int.Parse(UserId), true);
                else
                    //check them out
                    Requests.Requests.checkInOutUser(int.Parse(UserId), false);
            }

            updateFields();
            return Page();
        }
    }
}
