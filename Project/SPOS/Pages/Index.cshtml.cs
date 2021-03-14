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
            //used for loggin information and errors
            XmlConfigurator.ConfigureAndWatch(new FileInfo(Configurations.GetConfiguration("log4netFilename")));
        
            string url = Configurations.GetConfiguration("RestURL")+"/checkPassword/" +Code;
            LoggingMessage = $"Calling: {url} . Result: ";
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
            request.Method = "GET";

            HttpStatusCode status = HttpStatusCode.NotFound;

            try
            {
                using HttpWebResponse response = request.GetResponse() as HttpWebResponse;
                
                status = response.StatusCode;

                if (status == HttpStatusCode.OK)
                {
                    logger.Info(LoggingMessage + status);
                    return Redirect("./MainPage"); //direct to main page
                }
            }
            catch(Exception e)
            {
                logger.Error(LoggingMessage + e.Message);
                return Page(); //user failed to login
            }

            return Page();
        }
    }
}
