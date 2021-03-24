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
        public static bool validateUserByIdAndPin(int user_id,int pin)
        {
            //used for loggin information and errors
            XmlConfigurator.ConfigureAndWatch(new FileInfo(Configurations.GetConfiguration("log4netFilename")));

            string url = Configurations.GetConfiguration("RestURL") + $"/validateUserByIdAndPin/{user_id}/{pin}";
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

        public static string getIdOfUser(int pin)
        {
            //used for loggin information and errors
            XmlConfigurator.ConfigureAndWatch(new FileInfo(Configurations.GetConfiguration("log4netFilename")));

            string url = Configurations.GetConfiguration("RestURL") + "/getUserId/" + pin;
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

        public static Dictionary<int, string> getAllUsersByCheckIn(int checkIn)
        {
            //used for loggin information and errors
            XmlConfigurator.ConfigureAndWatch(new FileInfo(Configurations.GetConfiguration("log4netFilename")));

            string url = Configurations.GetConfiguration("RestURL") + "/getAllUsersByCheckIn/" + checkIn;
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
            request.Method = "GET";
            Dictionary<int, string> results = new Dictionary<int, string>();
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
                        results = JsonConvert.DeserializeObject<Dictionary<int, string>>(json);
                    }
                }
            }
            catch (System.Exception e)
            {
                logger.Error(loggingMessage + " " + e.Message);
            }

            return results;
        }

        public static bool checkInOutUser(int userId,bool checkIn)
        {
            char check_in_value = checkIn ? '1' : '0'; //if we want to check them in, we send the value of 1 
            //used for loggin information and errors
            XmlConfigurator.ConfigureAndWatch(new FileInfo(Configurations.GetConfiguration("log4netFilename")));

            string url = Configurations.GetConfiguration("RestURL") + $"/checkInOutUser/{check_in_value}/{userId}";
            string loggingMessage = $"Request sent: {url} .Result:";
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

        public static int CreateOrder(int cashier_id, string payment_method,int discount_applied)
        {
            int identity = 0;
            //used for loggin information and errors
            XmlConfigurator.ConfigureAndWatch(new FileInfo(Configurations.GetConfiguration("log4netFilename")));

            string url = Configurations.GetConfiguration("RestURL") + $"/createOrder/{cashier_id}/{payment_method}/{discount_applied}";
            string loggingMessage = $"Request sent: {url} . Result:";
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
            request.Method = "POST";

            HttpStatusCode status = HttpStatusCode.NotFound;
            try
            {
                using HttpWebResponse response = request.GetResponse() as HttpWebResponse;

                status = response.StatusCode;

                if (status == HttpStatusCode.OK)
                {
                    using (var streamReader = new StreamReader(response.GetResponseStream()))
                    {
                        identity = int.Parse(streamReader.ReadToEnd());
                    }

                    logger.Info(loggingMessage + " Success");
                }
            }
            catch (System.Exception e)
            {
                logger.Error(loggingMessage + " " + e.Message);
            }

            return identity;
        }
        public static void insertItemInOrder(long receipt_id, int item_id, int qty)
        {
            //used for loggin information and errors
            XmlConfigurator.ConfigureAndWatch(new FileInfo(Configurations.GetConfiguration("log4netFilename")));

            string url = Configurations.GetConfiguration("RestURL") + $"/insertItemInOrder/{receipt_id}/{item_id}/{qty}";
            string loggingMessage = $"Request sent: {url} . Result:";
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

        public static Dictionary<int,decimal> getTodaysOrders()
        {
            //used for loggin information and errors
            XmlConfigurator.ConfigureAndWatch(new FileInfo(Configurations.GetConfiguration("log4netFilename")));

            string url = Configurations.GetConfiguration("RestURL") + "/getAllTodaysOrders";
            string loggingMessage = $"Request sent: {url} . Result:";
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
            request.Method = "GET";
            Dictionary<int, decimal> results = new Dictionary<int, decimal>();
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
                        results = JsonConvert.DeserializeObject<Dictionary<int, decimal>>(json);
                    }

                    logger.Info(loggingMessage + " Success");
                }
            }
            catch (System.Exception e)
            {
                logger.Error(loggingMessage + " " + e.Message);
            }

            return results;
        }

        public static List<Receipt> getOrder(string orderId)
        {
            //used for loggin information and errors
            XmlConfigurator.ConfigureAndWatch(new FileInfo(Configurations.GetConfiguration("log4netFilename")));

            string url = Configurations.GetConfiguration("RestURL") + $"/getOrderById/{orderId}";
            string loggingMessage = $"Request sent: {url} . Result:";
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
            request.Method = "GET";
            List<Receipt> results = new List<Receipt>();
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
                        results = JsonConvert.DeserializeObject<List<Receipt>>(json);
                    }

                    logger.Info(loggingMessage + " Success");
                }
            }
            catch (System.Exception e)
            {
                logger.Error(loggingMessage + " " + e.Message);
            }

            return results;
        }

        public static void modifyReceipt(string orderId, string paymentMethod, int discount)
        {
            //used for loggin information and errors
            XmlConfigurator.ConfigureAndWatch(new FileInfo(Configurations.GetConfiguration("log4netFilename")));

            string url = Configurations.GetConfiguration("RestURL") + $"/modifyReceipt/{orderId}/{paymentMethod}/{discount}";
            string loggingMessage = $"Request sent: {url} . Result:";
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

        public static void removeReceiptContents(string orderId)
        {
            //used for loggin information and errors
            XmlConfigurator.ConfigureAndWatch(new FileInfo(Configurations.GetConfiguration("log4netFilename")));

            string url = Configurations.GetConfiguration("RestURL") + $"/removeReceiptContents/{orderId}";
            string loggingMessage = $"Request sent: {url} . Result:";
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
