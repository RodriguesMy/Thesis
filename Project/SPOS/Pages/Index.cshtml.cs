using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System.Net;

namespace SPOS.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        [BindProperty]
        public string Code { get; set; }

        public void OnGet(){}

        public ActionResult OnPost()
        {
            string url = "https://localhost:5001/checkPassword/"+Code;
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
            request.Method = "GET";

            HttpStatusCode status = HttpStatusCode.NotFound;

            try
            {
                using HttpWebResponse response = request.GetResponse() as HttpWebResponse;
                
                status = response.StatusCode;

                if (status == HttpStatusCode.OK) return Redirect("./MainPage"); //direct to main page
            }
            catch
            {
                return Page(); //user with this password does not exist
            }

            return Page();
        }
    }
}
