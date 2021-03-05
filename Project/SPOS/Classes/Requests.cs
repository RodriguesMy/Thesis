using Newtonsoft.Json;
using SPOS.Classes;
using SPOS.Models;
using System.Collections.Generic;
using System.IO;
using System.Net;

namespace SPOS.Requests
{
    public static class Requests
    {
        public static List<ItemType> GetItemTypes()
        {
            string url = "https://localhost:5001/getItemTypes";
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
            request.Method = "GET";
            List<ItemType> results = new List<ItemType>();
            HttpStatusCode status = HttpStatusCode.NotFound;

            try
            {
                using HttpWebResponse response = request.GetResponse() as HttpWebResponse;

                status = response.StatusCode;

                if (status == HttpStatusCode.OK)
                {
                    using (var streamReader = new StreamReader(response.GetResponseStream()))
                    {
                        var json = streamReader.ReadToEnd();
                        results = JsonConvert.DeserializeObject<List<ItemType>>(json);
                    }
                }
            }
            catch { }

            return results;
        }

        public static List<ItemCategory> GetItemCategories()
        {
            string url = "https://localhost:5001/getCategories";
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
            request.Method = "GET";
            List<ItemCategory> results = new List<ItemCategory>();
            HttpStatusCode status = HttpStatusCode.NotFound;

            try
            {
                using HttpWebResponse response = request.GetResponse() as HttpWebResponse;

                status = response.StatusCode;

                if (status == HttpStatusCode.OK)
                {
                    using (var streamReader = new StreamReader(response.GetResponseStream()))
                    {
                        var json = streamReader.ReadToEnd();
                        results = JsonConvert.DeserializeObject<List<ItemCategory>>(json);
                    }
                }
            }
            catch { }

            return results;
        }
    }
}
