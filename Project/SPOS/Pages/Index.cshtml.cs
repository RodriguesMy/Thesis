using log4net;
using log4net.Config;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using SPOS.Classes;
using System;
using System.IO;
using System.Net;

namespace SPOS.Pages
{
    public class IndexModel : PageModel
    {
        private static readonly ILog logger = LogManager.GetLogger(typeof(IndexModel));

        private readonly ILogger<IndexModel> _logger;

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        [BindProperty]
        public string Code { get; set; }

        string LoggingMessage { get; set; }
        public void OnGet(){}

        public ActionResult OnPost()
        {
            if (Requests.Requests.validateUser(int.Parse(Code)))
            {
                HttpContext.Session.SetString("userName",Requests.Requests.getNameOfUser(int.Parse(Code)));
                return Redirect("./MainPage"); //direct to main page
            }
        
            return Page();
        }
    }
}
