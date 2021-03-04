using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Newtonsoft.Json;
using SPOS.Classes;

namespace SPOS.Pages
{
    public class MainPageModel : PageModel
    {
        List<ItemType> itemTypes = new List<ItemType>();
        public string ErrorMessage;
        public String CategoriesHtmlContext;
        public void OnGet()
        {
            //validate user

            #region Get Categories

            string url = "https://localhost:5001/getCategories";
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
            request.Method = "GET";
            List<ItemType> results = new List<ItemType>();
            HttpStatusCode status = HttpStatusCode.NotFound;

            try
            {
                using HttpWebResponse response = request.GetResponse() as HttpWebResponse;

                status = response.StatusCode;

                if (status == HttpStatusCode.OK){

                    using (var streamReader = new StreamReader(response.GetResponseStream()))
                    {
                        var json = streamReader.ReadToEnd();
                        results = JsonConvert.DeserializeObject<List<ItemType>>(json);
                    }

                    //Fill HTML Context
                    CategoriesHtmlContext = "<div>hello</div>";
                }
            }
            catch
            {
                ErrorMessage = "Error connecting to rest.";
            }

            #endregion
        }
        public ActionResult OnPost()
        {
            return Page();
        }
    }
}
