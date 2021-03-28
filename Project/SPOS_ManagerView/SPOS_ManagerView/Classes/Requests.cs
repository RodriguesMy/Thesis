using log4net;
using log4net.Config;
using Newtonsoft.Json;
using SPOS_ManagerView.Models;
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

        #region Users
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

        public static Dictionary<long, List<Order>> getOrders(DateTime From, DateTime To, ref string SuccessMessage, ref string ErrorMessage)
        {
            //used for loggin information and errors
            XmlConfigurator.ConfigureAndWatch(new FileInfo(Configurations.GetConfiguration("log4netFilename")));

            string url = Configurations.GetConfiguration("RestURL") + $"/getOrders/{Uri.EscapeDataString(JsonConvert.SerializeObject(From))}/{Uri.EscapeDataString(JsonConvert.SerializeObject(To))}";
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
            request.Method = "GET";
            HttpStatusCode status = HttpStatusCode.NotFound;
            string loggingMessage = $"Request sent: {url} .Result:";
            Dictionary<long, List<Order>> result = new Dictionary<long, List<Order>>();
            try
            {
                using HttpWebResponse response = request.GetResponse() as HttpWebResponse;

                status = response.StatusCode;

                if (status == HttpStatusCode.OK)
                {
                    using (var streamReader = new StreamReader(response.GetResponseStream()))
                    {
                        var json = streamReader.ReadToEnd();
                        result = JsonConvert.DeserializeObject<Dictionary<long, List<Order>>>(json);
                    }
                    logger.Info(loggingMessage + " Success");
                    SuccessMessage = $"Successfully retrieved revenue. Download should start shortly.";
                }
            }
            catch (System.Exception e)
            {
                logger.Error(loggingMessage + " " + e.Message);
                ErrorMessage = $"Failed to retrieve revenue with the following error message: " + e.Message;
            }
            return result;
        }

        public static void createManagerAccount(string personal_Id, string username, string password, ref string SuccessMessage, ref string ErrorMessage)
        {
            //used for loggin information and errors
            XmlConfigurator.ConfigureAndWatch(new FileInfo(Configurations.GetConfiguration("log4netFilename")));

            string url = Configurations.GetConfiguration("RestURL") + $"/createManagerAccount/{personal_Id}/{username}/{password}";
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
            request.Method = "POST";
            HttpStatusCode status = HttpStatusCode.NotFound;
            string loggingMessage = $"Request sent: {url} .Result:";

            try
            {
                using HttpWebResponse response = request.GetResponse() as HttpWebResponse;

                status = response.StatusCode;

                if (status == HttpStatusCode.OK)
                {
                    logger.Info(loggingMessage + " Success");
                    SuccessMessage = $"Account successfully created. Download should start shortly.";
                }
            }
            catch (System.Exception e)
            {
                logger.Error(loggingMessage + " " + e.Message);
                ErrorMessage = $"Failed to create account with the following error message: " + e.Message;
            }
        }

        public static string getRevenue(DateTime From, DateTime To, ref string SuccessMessage, ref string ErrorMessage)
        {
            //used for loggin information and errors
            XmlConfigurator.ConfigureAndWatch(new FileInfo(Configurations.GetConfiguration("log4netFilename")));

            string url = Configurations.GetConfiguration("RestURL") + $"/getRevenue/{Uri.EscapeDataString(JsonConvert.SerializeObject(From))}/{Uri.EscapeDataString(JsonConvert.SerializeObject(To))}";
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
            request.Method = "GET";
            HttpStatusCode status = HttpStatusCode.NotFound;
            string loggingMessage = $"Request sent: {url} .Result:";
            double result = 0;
            try
            {
                using HttpWebResponse response = request.GetResponse() as HttpWebResponse;

                status = response.StatusCode;

                if (status == HttpStatusCode.OK)
                {
                    using (var streamReader = new StreamReader(response.GetResponseStream()))
                    {
                        var json = streamReader.ReadToEnd();
                        result = JsonConvert.DeserializeObject<double>(json);
                    }
                    logger.Info(loggingMessage + " Success");
                    SuccessMessage = $"Successfully retrieved revenue. Download should start shortly.";
                }
            }
            catch (System.Exception e)
            {
                logger.Error(loggingMessage + " " + e.Message);
                ErrorMessage = $"Failed to retrieve revenue with the following error message: " + e.Message;
            }
            return result.ToString("N2");
        }

        public static Dictionary<int,string> getJobTitles()
        { 
            //used for loggin information and errors
            XmlConfigurator.ConfigureAndWatch(new FileInfo(Configurations.GetConfiguration("log4netFilename")));

            string url = Configurations.GetConfiguration("RestURL") + "/getJobTitles";
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
        public static void createUser(User user,ref string SuccessMessage, ref string ErrorMessage)
        {
            //used for loggin information and errors
            XmlConfigurator.ConfigureAndWatch(new FileInfo(Configurations.GetConfiguration("log4netFilename")));

            string url = Configurations.GetConfiguration("RestURL") + "/createUser/" + Uri.EscapeDataString(JsonConvert.SerializeObject(user));
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
            request.Method = "POST";
            HttpStatusCode status = HttpStatusCode.NotFound;
            string loggingMessage = $"Request sent: {url} .Result:";

            try
            {
                using HttpWebResponse response = request.GetResponse() as HttpWebResponse;

                status = response.StatusCode;

                if (status == HttpStatusCode.OK)
                {
                    logger.Info(loggingMessage + " Success");
                    SuccessMessage = "User successfully created.";
                }
            }
            catch (System.Exception e)
            {
                logger.Error(loggingMessage + " " + e.Message);
                ErrorMessage = "Creation of user failed with the following error message: " + e.Message;
            }
        }
        public static void updateStaffMember(User user, ref string SuccessMessage, ref string ErrorMessage)
        {
            //used for loggin information and errors
            XmlConfigurator.ConfigureAndWatch(new FileInfo(Configurations.GetConfiguration("log4netFilename")));

            string url = Configurations.GetConfiguration("RestURL") + "/updateStaffMember/" + Uri.EscapeDataString(JsonConvert.SerializeObject(user));
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
            request.Method = "POST";
            HttpStatusCode status = HttpStatusCode.NotFound;
            string loggingMessage = $"Request sent: {url} .Result:";

            try
            {
                using HttpWebResponse response = request.GetResponse() as HttpWebResponse;

                status = response.StatusCode;

                if (status == HttpStatusCode.OK)
                {
                    logger.Info(loggingMessage + " Success");
                    SuccessMessage = $"User: {user.FName} successfully updated.";
                }
            }
            catch (System.Exception e)
            {
                logger.Error(loggingMessage + " " + e.Message);
                ErrorMessage = $"Update failed with the following error message: " + e.Message;
            }
        }
        public static List<User> getWorkingMinutes(DateTime From,DateTime To, ref string SuccessMessage, ref string ErrorMessage)
        {
            //used for loggin information and errors
            XmlConfigurator.ConfigureAndWatch(new FileInfo(Configurations.GetConfiguration("log4netFilename")));

            string url = Configurations.GetConfiguration("RestURL") + $"/getWorkingMinutes/{Uri.EscapeDataString(JsonConvert.SerializeObject(From))}/{Uri.EscapeDataString(JsonConvert.SerializeObject(To))}";
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
            request.Method = "GET";
            HttpStatusCode status = HttpStatusCode.NotFound;
            string loggingMessage = $"Request sent: {url} .Result:";
            List<User> users = new List<User>();
            try
            {
                using HttpWebResponse response = request.GetResponse() as HttpWebResponse;

                status = response.StatusCode;

                if (status == HttpStatusCode.OK)
                {
                    using (var streamReader = new StreamReader(response.GetResponseStream()))
                    {
                        var json = streamReader.ReadToEnd();
                        users = JsonConvert.DeserializeObject<List<User>>(json);
                    }
                    logger.Info(loggingMessage + " Success");
                    SuccessMessage = $"Successfully retrieved working hours.";
                }
            }
            catch (System.Exception e)
            {
                logger.Error(loggingMessage + " " + e.Message);
                ErrorMessage = $"Failed to retrieve working hours with the following error message: " + e.Message;
            }
            return users;
        }
        public static User GetUserByPersonalId(String id)
        {
            
            //used for loggin information and errors
            XmlConfigurator.ConfigureAndWatch(new FileInfo(Configurations.GetConfiguration("log4netFilename")));

            string url = Configurations.GetConfiguration("RestURL") + "/GetUserByPersonalId/"+id;
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
            request.Method = "GET";
            User user = new User();
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
                        user = JsonConvert.DeserializeObject<User>(json);
                    }
                }
            }
            catch (System.Exception e)
            {
                logger.Error(loggingMessage + " " + e.Message);
            }

            return user;
        }
        public static void createPOSAccount(string personal_id,string password, ref string SuccessMessage, ref string ErrorMessage)
        {
            //used for loggin information and errors
            XmlConfigurator.ConfigureAndWatch(new FileInfo(Configurations.GetConfiguration("log4netFilename")));

            string url = Configurations.GetConfiguration("RestURL") + $"/createPOSAccount/{personal_id}/{password}";
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
            request.Method = "POST";
            HttpStatusCode status = HttpStatusCode.NotFound;
            string loggingMessage = $"Request sent: {url} .Result:";

            try
            {
                using HttpWebResponse response = request.GetResponse() as HttpWebResponse;

                status = response.StatusCode;

                if (status == HttpStatusCode.OK)
                {
                    logger.Info(loggingMessage + " Success");
                    SuccessMessage = $"Account successfully created.";
                }
            }
            catch (System.Exception e)
            {
                logger.Error(loggingMessage + " " + e.Message);
                ErrorMessage = $"Failed to create account with the following error message: " + e.Message;
            }
        }
        #endregion
    }
}
