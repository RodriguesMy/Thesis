using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using SPOS_ManagerView.Classes;
using System;

namespace SPOS_ManagerView.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        [BindProperty]
        public string Username { get; set; }
        [BindProperty]
        public string Password { get; set; }
        public string ErrorMessage { get; set; }

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public ActionResult OnGet()
        {

            if (HttpContext.Session.GetString("username") == null)
            {
                return Page(); 
            }

            return Redirect("control/index"); 
        }
        public ActionResult OnPost()
        {
            if (string.IsNullOrEmpty(Username) || string.IsNullOrEmpty(Password))
            {
                ErrorMessage = "Invalid Credentials";
                return Page();
            }
            if (Requests.validateManager(Username, StaticFunctions.GetHash(Password)))
            {

                HttpContext.Session.SetString("username", Username);
                return Redirect("control/index");
            }
            else
            {
                ErrorMessage = "Invalid Credentials";
            }

            return Page();
        }
    }
}
