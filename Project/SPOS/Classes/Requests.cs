using log4net;
using log4net.Config;
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
        private static readonly ILog logger = LogManager.GetLogger(typeof(Requests));

        #region Menu Requests
        public static List<ItemType> GetItemTypes()
        {
            //used for loggin information and errors
            XmlConfigurator.ConfigureAndWatch(new FileInfo(Configurations.GetConfiguration("log4netFilename")));

            string url = Configurations.GetConfiguration("RestURL") + "/getItemTypes";
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
            request.Method = "GET";
            List<ItemType> results = new List<ItemType>();
            HttpStatusCode status = HttpStatusCode.NotFound;

            string loggingMessage = $"Request sent: {url} .Result:";
            try
            {
                using HttpWebResponse response = request.GetResponse() as HttpWebResponse;

                status = response.StatusCode;

                if (status == HttpStatusCode.OK)
                {
                    logger.Info(loggingMessage + " Success");
                    using (var streamReader = new StreamReader(response.GetResponseStream()))
                    {
                        var json = streamReader.ReadToEnd();
                        results = JsonConvert.DeserializeObject<List<ItemType>>(json);
                    }
                }
            }
            catch(System.Exception e) {
                logger.Error(loggingMessage + " " + e.Message);
            }

            return results;
        }

        public static List<ItemCategory> GetItemCategories()
        {
            //used for loggin information and errors
            XmlConfigurator.ConfigureAndWatch(new FileInfo(Configurations.GetConfiguration("log4netFilename")));

            string url = Configurations.GetConfiguration("RestURL") + "/getCategories";
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
            request.Method = "GET";
            List<ItemCategory> results = new List<ItemCategory>();
            HttpStatusCode status = HttpStatusCode.NotFound;
            string loggingMessage = $"Request sent: {url} .Result:";

            try
            {
                using HttpWebResponse response = request.GetResponse() as HttpWebResponse;

                status = response.StatusCode;

                if (status == HttpStatusCode.OK)
                {
                    logger.Info(loggingMessage + " Success");
                    using (var streamReader = new StreamReader(response.GetResponseStream()))
                    {
                        var json = streamReader.ReadToEnd();
                        results = JsonConvert.DeserializeObject<List<ItemCategory>>(json);
                    }
                }
            }
            catch (System.Exception e)
            {
                logger.Error(loggingMessage + " " + e.Message);
            }

            return results;
        }
        public static List<Item> GetItemsFromType(int item_type)
        {
            //used for loggin information and errors
            XmlConfigurator.ConfigureAndWatch(new FileInfo(Configurations.GetConfiguration("log4netFilename")));

            string url = Configurations.GetConfiguration("RestURL") + "/getItems/" + item_type;
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
            request.Method = "GET";
            List<Item> results = new List<Item>();
            HttpStatusCode status = HttpStatusCode.NotFound;
            string loggingMessage = $"Request sent: {url} .Result:";

            try
            {
                using HttpWebResponse response = request.GetResponse() as HttpWebResponse;

                status = response.StatusCode;

                if (status == HttpStatusCode.OK)
                {
                    logger.Info(loggingMessage + " Success");
                    using (var streamReader = new StreamReader(response.GetResponseStream()))
                    {
                        var json = streamReader.ReadToEnd();
                        results = JsonConvert.DeserializeObject<List<Item>>(json);
                    }
                }
            }
            catch(System.Exception e) {
                logger.Error(loggingMessage + " " + e.Message);
                    }

            return results;
        }
        #endregion

        #region User Requests
        public static string getNameOfUser(int pin)
        {
            //used for loggin information and errors
            XmlConfigurator.ConfigureAndWatch(new FileInfo(Configurations.GetConfiguration("log4netFilename")));

            string url = Configurations.GetConfiguration("RestURL") + "/getUserName/" + pin;
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
            request.Method = "GET";
            string results = "";
            HttpStatusCode status = HttpStatusCode.NotFound;
            string loggingMessage = $"Request sent: {url} .Result:";

            try
            {
                using HttpWebResponse response = request.GetResponse() as HttpWebResponse;

                status = response.StatusCode;

                if (status == HttpStatusCode.OK)
                {
                    logger.Info(loggingMessage + " Success");
                    using (var streamReader = new StreamReader(response.GetResponseStream()))
                    {
                        results += streamReader.ReadToEnd();
                    }
                }
            }
            catch (System.Exception e)
            {
                logger.Error(loggingMessage + " " + e.Message);
            }

            return results;
        }

        public static bool validateUser(int pin)
        {
            //used for loggin information and errors
            XmlConfigurator.ConfigureAndWatch(new FileInfo(Configurations.GetConfiguration("log4netFilename")));

            string url = Configurations.GetConfiguration("RestURL") + "/checkPassword/" + pin;
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
            catch (System.Exception e)
            {
                logger.Error(loggingMessage + " " + e.Message);
                return false;
            }

            return false;
        }
        #endregion

        #region Order Requests

        public static void SendOrder(List<Receipt> receipt)
        {
            //used for loggin information and errors
            XmlConfigurator.ConfigureAndWatch(new FileInfo(Configurations.GetConfiguration("log4netFilename")));

            string url = Configurations.GetConfiguration("RestURL") + "/sendOrder";
            string json = "";
            string loggingMessage = $"Request sent: {url} .Json Contents: {json} Result:";
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
            request.Method = "POST";

            HttpStatusCode status = HttpStatusCode.NotFound;
            try
            {
                using HttpWebResponse response = request.GetResponse() as HttpWebResponse;

                status = response.StatusCode;

                if (status == HttpStatusCode.OK)
                {
                    logger.Info(loggingMessage + " Success");
                }
            }
            catch (System.Exception e)
            {
                logger.Error(loggingMessage + " " + e.Message);
            }
        }

        #endregion
    }
}
