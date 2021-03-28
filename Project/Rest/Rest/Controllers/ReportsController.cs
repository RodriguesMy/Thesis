using log4net;
using log4net.Config;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Rest.Classes;
using Rest.Models;
using Rest.SharedClasses;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace Rest.Controllers
{
    public class ReportsController : Controller
    {
        private static readonly ILog logger = LogManager.GetLogger(typeof(ReportsController));
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        [Route("getWorkingMinutes/{FromJson}/{ToJson}")]
        public ActionResult getWorkingMinutes(String FromJson, String ToJson)
        {
            DateTime from = JsonConvert.DeserializeObject<DateTime>(FromJson);
            DateTime to = JsonConvert.DeserializeObject<DateTime>(ToJson);
            //used for loggin information and errors
            XmlConfigurator.ConfigureAndWatch(new FileInfo(Configurations.GetConfiguration("log4netFilename")));

            //create connection to the database
            try {
                SqlConnection sqlConnection = new SqlConnection(Configurations.GetConfiguration("DBConnectionString"));
                //year, month, day, hour, minute, seconds, milliseconds
                String query = $"declare @Selected_From as datetime = DATETIMEFROMPARTS({from.Year},{from.Month},{from.Day},{from.Hour},{from.Minute},{from.Second},{0})"+
                                $"declare @Selected_To as datetime = DATETIMEFROMPARTS({to.Year},{to.Month},{to.Day},{to.Hour},{to.Minute},{to.Second},{0})"+
                                $"exec getWorkingMinutes @Selected_From,@Selected_To"; 

                sqlConnection.Open();

                SqlCommand command = new SqlCommand(query, sqlConnection);

                //execute query
                SqlDataReader sqlDataReader = command.ExecuteReader();
                List<User> user = new List<User>();
                while (sqlDataReader.Read()) {
                    user.Add(new User {
                        FName = sqlDataReader.GetString(0).Trim(),
                        MName = sqlDataReader.GetString(1).Trim(),
                        LName = sqlDataReader.GetString(2).Trim(),
                        personal_id = sqlDataReader.GetString(3).Trim(),
                        working_minutes = sqlDataReader.GetInt32(4),
                        salary_per_hour = sqlDataReader.GetDecimal(5).ToString("N2")
                    });
                }

                //close all connections
                sqlDataReader.Close();
                command.Dispose();
                sqlConnection.Close();

                ActionResult res = user.Count != 0 ? Ok(user) : NotFound();
                logger.Info($"Received Request: 'getJobTitles'. Result: {res}");
                return res;
            }
            catch (Exception e) {
                logger.Error($"Received Request: 'getJobTitles'. Error: {e.Message}");
                return BadRequest(e.Message);
            }
        }

        [HttpGet]
        [Route("getRevenue/{fromJson}/{toJson}")]
        public ActionResult getRevenue(String fromJson, String toJson)
        {
            DateTime from = JsonConvert.DeserializeObject<DateTime>(fromJson);
            DateTime to = JsonConvert.DeserializeObject<DateTime>(toJson);

            //used for loggin information and errors
            XmlConfigurator.ConfigureAndWatch(new FileInfo(Configurations.GetConfiguration("log4netFilename")));

            //create connection to the database
            try {
                SqlConnection sqlConnection = new SqlConnection(Configurations.GetConfiguration("DBConnectionString"));
                //year, month, day, hour, minute, seconds, milliseconds
                String query = $"declare @Selected_From as datetime = DATETIMEFROMPARTS({from.Year},{from.Month},{from.Day},{from.Hour},{from.Minute},{from.Second},{0})" +
                                $"declare @Selected_To as datetime = DATETIMEFROMPARTS({to.Year},{to.Month},{to.Day},{to.Hour},{to.Minute},{to.Second},{0})" +
                                $"exec getRevenue @Selected_From,@Selected_To";

                sqlConnection.Open();

                SqlCommand command = new SqlCommand(query, sqlConnection);

                // execute query
                SqlDataReader sqlDataReader = command.ExecuteReader();
                decimal result = 0;
                while (sqlDataReader.Read()) {
                    result = sqlDataReader.GetDecimal(0);
                }

                //close all connections
                sqlDataReader.Close();
                command.Dispose();
                sqlConnection.Close();

                logger.Info($"Received Request: 'getRevenue/{fromJson}/{toJson}'. Result: {result}");
                return Ok(result);
            }
            catch (Exception e) {
                logger.Error($"Received Request: 'getRevenue/{fromJson}/{toJson}'. Error: {e.Message}");
                return BadRequest(e.Message);
            }
        }

        [HttpGet]
        [Route("getOrders/{fromJson}/{toJson}")]
        public ActionResult getOrders(String fromJson, String toJson)
        {
            DateTime from = JsonConvert.DeserializeObject<DateTime>(fromJson);
            DateTime to = JsonConvert.DeserializeObject<DateTime>(toJson);

            //used for loggin information and errors
            XmlConfigurator.ConfigureAndWatch(new FileInfo(Configurations.GetConfiguration("log4netFilename")));

            //create connection to the database
            try {
                SqlConnection sqlConnection = new SqlConnection(Configurations.GetConfiguration("DBConnectionString"));
                //year, month, day, hour, minute, seconds, milliseconds
                String query = $"declare @Selected_From as datetime = DATETIMEFROMPARTS({from.Year},{from.Month},{from.Day},{from.Hour},{from.Minute},{from.Second},{0})" +
                                $"declare @Selected_To as datetime = DATETIMEFROMPARTS({to.Year},{to.Month},{to.Day},{to.Hour},{to.Minute},{to.Second},{0})" +
                                $"exec getOrders @Selected_From,@Selected_To";

                sqlConnection.Open();

                SqlCommand command = new SqlCommand(query, sqlConnection);

                // execute query
                SqlDataReader sqlDataReader = command.ExecuteReader();
                Dictionary<long, List<Order>> allOrders = new Dictionary<long, List<Order>>();
                while (sqlDataReader.Read()) {
                    try {
                        List<Order> newOrders = new List<Order>();
                        newOrders.Add(new Order() {
                            datetime_created = sqlDataReader.GetDateTime(1),
                            datetime_updated = sqlDataReader.GetDateTime(2),
                            payment_method = sqlDataReader.GetString(3),
                            discount_applied = sqlDataReader.GetInt32(4),
                            item_name = sqlDataReader.GetString(5),
                            qty = sqlDataReader.GetInt16(6),
                            total = sqlDataReader.GetDecimal(7)
                        });
                        allOrders.Add(sqlDataReader.GetInt64(0), newOrders);
                    }
                    catch (Exception e) {
                        //order id already exists in the dictionary
                        allOrders[sqlDataReader.GetInt64(0)].Add(new Order() {
                            datetime_created = sqlDataReader.GetDateTime(1),
                            datetime_updated = sqlDataReader.GetDateTime(2),
                            payment_method = sqlDataReader.GetString(3),
                            discount_applied = sqlDataReader.GetInt32(4),
                            item_name = sqlDataReader.GetString(5),
                            qty = sqlDataReader.GetInt16(6),
                            total = sqlDataReader.GetDecimal(7)
                        });
                    }
                }

                //close all connections
                sqlDataReader.Close();
                command.Dispose();
                sqlConnection.Close();

                logger.Info($"Received Request: 'getOrders/{fromJson}/{toJson}'. Result: {allOrders}");
                return Ok(allOrders);
            }
            catch (Exception e) {
                logger.Error($"Received Request: 'getOrders/{fromJson}/{toJson}'. Error: {e.Message}");
                return BadRequest(e.Message);
            }
        }
    }
}
