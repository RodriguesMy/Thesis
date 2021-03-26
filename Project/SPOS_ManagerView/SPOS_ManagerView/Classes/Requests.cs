using log4net;
using log4net.Config;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace SPOS_ManagerView.Classes
{
    public static class Requests
    {
        private static readonly ILog logger = LogManager.GetLogger(typeof(Requests));
        public static bool validateManager(string username, string password)
        {
            //used for loggin information and errors
            XmlConfigurator.ConfigureAndWatch(new FileInfo(Configurations.GetConfiguration("log4netFilename")));

            string url = Configurations.GetConfiguration("RestURL") + $"/validateManager/{username}/{password}";
            string loggingMessage = $"Request sent: {url} .Result:";
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
            request.Method = "GET";

            HttpStatusCode status = HttpStatusCode.NotFound;

            try
            {
                using HttpWebResponse response = request.GetResponse() as HttpWebResponse;

                status = response.StatusCode;

                if (status == HttpStatusCode.OK)
                {
                    logger.Info(loggingMessage + " Success");
                    return true;
                }
            }
            catch (Exception e)
            {
                logger.Error(loggingMessage + " " + e.Message);
                return false;
            }

            return false;
        }
    }
}
