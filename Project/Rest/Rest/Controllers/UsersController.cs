using log4net;
using log4net.Config;
using Microsoft.AspNetCore.Mvc;
using Rest.SharedClasses;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.IO;

namespace Rest.Controllers
{
    public class UsersController : Controller
    {
        private static readonly ILog logger = LogManager.GetLogger(typeof(UsersController));
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        [Route("validateUserByIdAndPin/{userId}/{pin}")]
        public ActionResult validateUserByIdAndPin(String userId, String pin)
        {
            //used for loggin information and errors
            XmlConfigurator.ConfigureAndWatch(new FileInfo(Configurations.GetConfiguration("log4netFilename")));

            //create connection to the database
            try {
                SqlConnection sqlConnection = new SqlConnection(Configurations.GetConfiguration("DBConnectionString"));
                String query = $"exec dbo.validateUserByIdAndPin {userId},{pin}";
                sqlConnection.Open();

                SqlCommand command = new SqlCommand(query, sqlConnection);

                //execute query
                SqlDataReader sqlDataReader = command.ExecuteReader();
                int linesReceived = 0;
                while (sqlDataReader.Read()) {
                    linesReceived++;
                }

                //close all connections
                sqlDataReader.Close();
                command.Dispose();
                sqlConnection.Close();

                ActionResult res = linesReceived > 0 ? Ok() : NotFound();
                logger.Info($"Received Request: 'validateUserByIdAndPin/{userId}/{pin}'. Result: {res}");
                return res;
            }
            catch (Exception e) {
                logger.Error($"Received Request: 'validateUserByIdAndPin/{userId}/{pin}'. Error: {e.Message}");
                return BadRequest(e.Message);
            }
        }

        [HttpGet]
        [Route("checkPassword/{pin}")]
        public ActionResult CheckCredentials(String pin)
        {
            //used for loggin information and errors
            XmlConfigurator.ConfigureAndWatch(new FileInfo(Configurations.GetConfiguration("log4netFilename")));

            //create connection to the database
            try {
                SqlConnection sqlConnection = new SqlConnection(Configurations.GetConfiguration("DBConnectionString"));
                String query = "exec dbo.validateUser " + pin;
                sqlConnection.Open();

                SqlCommand command = new SqlCommand(query, sqlConnection);

                //execute query
                SqlDataReader sqlDataReader = command.ExecuteReader();
                int linesReceived = 0;
                while (sqlDataReader.Read()) {
                    linesReceived++;
                }

                //close all connections
                sqlDataReader.Close();
                command.Dispose();
                sqlConnection.Close();

                ActionResult res = linesReceived > 0 ? Ok() : NotFound();
                logger.Info($"Received Request: 'checkPassword/{pin}'. Result: {res}");
                return res;
            }catch(Exception e) {
                logger.Error($"Received Request: 'checkPassword/{pin}'. Error: {e.Message}");
                return BadRequest(e.Message);
            }      
        }

        [HttpGet]
        [Route("getUserName/{pin}")]
        public ActionResult getUserName(String pin)
        {
            //used for loggin information and errors
            XmlConfigurator.ConfigureAndWatch(new FileInfo(Configurations.GetConfiguration("log4netFilename")));

            //create connection to the database
            try {
                SqlConnection sqlConnection = new SqlConnection(Configurations.GetConfiguration("DBConnectionString"));
                String query = "exec dbo.getUserName " + pin;
                sqlConnection.Open();

                SqlCommand command = new SqlCommand(query, sqlConnection);

                //execute query
                SqlDataReader sqlDataReader = command.ExecuteReader();
                string name = "";
                while (sqlDataReader.Read()) {
                    name = $"{sqlDataReader.GetString(0).Trim()} {sqlDataReader.GetString(1).Trim()} {sqlDataReader.GetString(2).Trim()}";
                }

                //close all connections
                sqlDataReader.Close();
                command.Dispose();
                sqlConnection.Close();

                ActionResult res = name != "" ? Ok(name) : NotFound();
                logger.Info($"Received Request: 'getUserName/{pin}'. Result: {res}");
                return res;
            }
            catch (Exception e) {
                logger.Error($"Received Request: 'getUserName/{pin}'. Error: {e.Message}");
                return BadRequest(e.Message);
            }
        }

        [HttpGet]
        [Route("getUserID/{pin}")]
        public ActionResult getUserID(String pin)
        {
            //used for loggin information and errors
            XmlConfigurator.ConfigureAndWatch(new FileInfo(Configurations.GetConfiguration("log4netFilename")));

            //create connection to the database
            try {
                SqlConnection sqlConnection = new SqlConnection(Configurations.GetConfiguration("DBConnectionString"));
                String query = "exec dbo.getUserId " + pin;
                sqlConnection.Open();

                SqlCommand command = new SqlCommand(query, sqlConnection);

                //execute query
                SqlDataReader sqlDataReader = command.ExecuteReader();
                int id = -1;
                while (sqlDataReader.Read()) {
                    id = sqlDataReader.GetInt32(0);
                }

                //close all connections
                sqlDataReader.Close();
                command.Dispose();
                sqlConnection.Close();

                ActionResult res = id != -1 ? Ok(id) : NotFound();
                logger.Info($"Received Request: 'getUserId/{pin}'. Result: {res}");
                return res;
            }
            catch (Exception e) {
                logger.Error($"Received Request: 'getUserId/{pin}'. Error: {e.Message}");
                return BadRequest(e.Message);
            }
        }
        
        //returns all users, second parameter is for getting users which are checked in or not
        //checkin = 0 return users that are not checked-in
        //checkin = 1 returns users that are checked-in
        //anything else will not return anything
        [HttpGet]
        [Route("getAllUsersByCheckIn/{checkedIn}")]
        public ActionResult getAllUsersByCheckIn(String checkedIn)
        {
            //used for loggin information and errors
            XmlConfigurator.ConfigureAndWatch(new FileInfo(Configurations.GetConfiguration("log4netFilename")));

            //create connection to the database
            try {
                SqlConnection sqlConnection = new SqlConnection(Configurations.GetConfiguration("DBConnectionString"));
                String query = "exec dbo.getAllUsersByCheckIn " + checkedIn;
                sqlConnection.Open();

                SqlCommand command = new SqlCommand(query, sqlConnection);

                //execute query
                SqlDataReader sqlDataReader = command.ExecuteReader();
                Dictionary<int,string> userIdsReceived= new Dictionary<int, string>();
                while (sqlDataReader.Read()) {
                    userIdsReceived.Add(sqlDataReader.GetInt32(0), sqlDataReader.GetString(1).Trim()+" " + sqlDataReader.GetString(2).Trim()+" " + sqlDataReader.GetString(3).Trim());
                }

                //close all connections
                sqlDataReader.Close();
                command.Dispose();
                sqlConnection.Close();

                ActionResult res = userIdsReceived.Count != 0 ? Ok(userIdsReceived) : NotFound();
                logger.Info($"Received Request: 'getAllUsers/{checkedIn}'. Result: {res}");
                return res;
            }
            catch (Exception e) {
                logger.Error($"Received Request: 'getAllUsers/{checkedIn}. Error: {e.Message}");
                return BadRequest(e.Message);
            }
        }

        #region Check In/Out Users

        [HttpPost]
        [Route("checkInOutUser/{checkIn}/{userId}")]
        public ActionResult checkInOutUser(String checkIn, String userId)
        {
            //used for loggin information and errors
            XmlConfigurator.ConfigureAndWatch(new FileInfo(Configurations.GetConfiguration("log4netFilename")));

            //create connection to the database
            try {
                SqlConnection sqlConnection = new SqlConnection(Configurations.GetConfiguration("DBConnectionString"));
                String query = $"exec dbo.checkInOutUser {checkIn},{userId}";
                sqlConnection.Open();

                SqlCommand command = new SqlCommand(query, sqlConnection);

                //execute query
                int rowsAffected = command.ExecuteNonQuery();

                //close all connections
                command.Dispose();
                sqlConnection.Close();

                ActionResult res = rowsAffected > 0 ? Ok() : NotFound();
                logger.Info($"Received Request: 'checkInOutUsers/{checkIn}/{userId}'. Result: {res}");
                return res;
            }
            catch (Exception e) {
                logger.Error($"Received Request: 'checkInOutUsers/{checkIn}/{userId}. Error: {e.Message}");
                return BadRequest(e.Message);
            }
        }
        #endregion
    }
}
