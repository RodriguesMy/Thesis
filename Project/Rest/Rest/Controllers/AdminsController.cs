using log4net;
using log4net.Config;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Rest.Classes;
using Rest.SharedClasses;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace Rest.Controllers
{
    public class AdminsController : Controller
    {
        private static readonly ILog logger = LogManager.GetLogger(typeof(AdminsController));
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        [Route("validateManager/{username}/{password}")]
        public ActionResult validateManager(String username, String password)
        {
            //used for loggin information and errors
            XmlConfigurator.ConfigureAndWatch(new FileInfo(Configurations.GetConfiguration("log4netFilename")));

            //create connection to the database
            try {
                SqlConnection sqlConnection = new SqlConnection(Configurations.GetConfiguration("DBConnectionString"));
                String query = $"exec dbo.validateManager {username},{password}";
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
                logger.Info($"Received Request: 'validateManager/{username}/{password}'. Result: {res}");
                return res;
            }
            catch (Exception e) {
                logger.Error($"Received Request: 'validateManager/{username}/{password}'. Error: {e.Message}");
                return BadRequest(e.Message);
            }
        }

        [HttpGet]
        [Route("getJobTitles")]
        public ActionResult getJobTitles()
        {
            //used for loggin information and errors
            XmlConfigurator.ConfigureAndWatch(new FileInfo(Configurations.GetConfiguration("log4netFilename")));

            //create connection to the database
            try {
                SqlConnection sqlConnection = new SqlConnection(Configurations.GetConfiguration("DBConnectionString"));
                String query = $"exec dbo.getJobTitles";
                sqlConnection.Open();

                SqlCommand command = new SqlCommand(query, sqlConnection);

                //execute query
                SqlDataReader sqlDataReader = command.ExecuteReader();
                Dictionary<int, string> jobTitles = new Dictionary<int, string>();
                while (sqlDataReader.Read()) {
                    jobTitles.Add(sqlDataReader.GetInt16(0), sqlDataReader.GetString(1));
                }

                //close all connections
                sqlDataReader.Close();
                command.Dispose();
                sqlConnection.Close();

                ActionResult res = jobTitles.Count != 0  ? Ok(jobTitles) : NotFound();
                logger.Info($"Received Request: 'getJobTitles'. Result: {res}");
                return res;
            }
            catch (Exception e) {
                logger.Error($"Received Request: 'getJobTitles'. Error: {e.Message}");
                return BadRequest(e.Message);
            }
        }

        [HttpPost]
        [Route("createUser/{userJson}")]
        public ActionResult createUser(string userJson)
        {
            //used for loggin information and errors
            XmlConfigurator.ConfigureAndWatch(new FileInfo(Configurations.GetConfiguration("log4netFilename")));

            User user = JsonConvert.DeserializeObject<User>(userJson);
            //create connection to the database
            try {
                SqlConnection sqlConnection = new SqlConnection(Configurations.GetConfiguration("DBConnectionString"));

                //Example: exec dbo.createStaffMember 2,'Andreas','','Ioannou','432343','90','12','street','M','andreas@gmail.com','27-02-2000 12:00:00 AM',5,2211563,1,0
                String query = $"exec dbo.createStaffMember {user.jobTitle},'{user.FName}','{user.MName}','{user.LName}','{user.personal_id}','{user.address_no}'," +
                    $"'{user.postal_code}','{user.address_street}','{user.gender}','{user.email}','{user.DOB}',{user.salary_per_hour},{user.phone_no},{(user.is_active ? '1' : '0')},{(user.is_manager ? '1' : '0')}";

                sqlConnection.Open();

                SqlCommand command = new SqlCommand(query, sqlConnection);

                //execute query
                int rowsAffected = command.ExecuteNonQuery();

                //close all connections
                command.Dispose();
                sqlConnection.Close();

                ActionResult res = rowsAffected > 0 ? Ok() : BadRequest();
                logger.Info($"Received Request: 'createUser/{userJson}'. Result: {res}");
                return res;
            }
            catch (Exception e) {
                logger.Error($"Received Request: 'createUser/{userJson}'. Error: {e.Message}");
                return BadRequest(e.Message);
            }
        }

        [HttpPost]
        [Route("updateStaffMember/{userJson}")]
        public ActionResult updateStaffMember(string userJson)
        {
            //used for loggin information and errors
            XmlConfigurator.ConfigureAndWatch(new FileInfo(Configurations.GetConfiguration("log4netFilename")));

            User user = JsonConvert.DeserializeObject<User>(userJson);
            //create connection to the database
            try {
                SqlConnection sqlConnection = new SqlConnection(Configurations.GetConfiguration("DBConnectionString"));

                //Example: exec dbo.updateStaffMember 2,'Andreas','','Ioannou','432343','90','12','street','M','andreas@gmail.com','27-02-2000 12:00:00 AM',5,2211563,1,0
                String query = $"exec dbo.updateStaffMember {user.jobTitle},'{user.FName}','{user.MName}','{user.LName}','{user.personal_id}','{user.address_no}'," +
                    $"'{user.postal_code}','{user.address_street}','{user.gender}','{user.email}','{user.DOB}',{user.salary_per_hour},{user.phone_no},{(user.is_active ? '1' : '0')},{(user.is_manager ? '1' : '0')}";

                sqlConnection.Open();

                SqlCommand command = new SqlCommand(query, sqlConnection);

                //execute query
                int rowsAffected = command.ExecuteNonQuery();

                //close all connections
                command.Dispose();
                sqlConnection.Close();

                ActionResult res = rowsAffected > 0 ? Ok() : BadRequest();
                logger.Info($"Received Request: 'createUser/{userJson}'. Result: {res}");
                return res;
            }
            catch (Exception e) {
                logger.Error($"Received Request: 'createUser/{userJson}'. Error: {e.Message}");
                return BadRequest(e.Message);
            }
        }

        [HttpGet]
        [Route("GetUserByPersonalId/{id}")]
        public ActionResult GetUserByPersonalId(String id)
        {
            //used for loggin information and errors
            XmlConfigurator.ConfigureAndWatch(new FileInfo(Configurations.GetConfiguration("log4netFilename")));

            //create connection to the database
            try {
                SqlConnection sqlConnection = new SqlConnection(Configurations.GetConfiguration("DBConnectionString"));
                String query = $"exec dbo.GetUserByPersonalId {id}";
                sqlConnection.Open();

                SqlCommand command = new SqlCommand(query, sqlConnection);

                //execute query
                SqlDataReader sqlDataReader = command.ExecuteReader();
                User user = new User();
                while (sqlDataReader.Read()) {
                    user.jobTitle = sqlDataReader.GetInt16(1).ToString();
                    user.FName = sqlDataReader.GetString(2).Trim();
                    user.MName = sqlDataReader.GetString(3).Trim();
                    user.LName = sqlDataReader.GetString(4).Trim();
                    user.personal_id = sqlDataReader.GetString(5).Trim();
                    user.address_no = sqlDataReader.GetString(6).Trim();
                    user.postal_code = sqlDataReader.GetString(7).Trim();
                    user.address_street = sqlDataReader.GetString(8).Trim();
                    user.gender = sqlDataReader.GetString(9).Trim();
                    user.email = sqlDataReader.GetString(10).Trim();
                    user.DOB = DateTime.Parse(sqlDataReader.GetString(11));
                    user.salary_per_hour = sqlDataReader.GetDecimal(12).ToString("N2");
                    user.phone_no = sqlDataReader.GetInt32(13).ToString();
                    user.is_active = sqlDataReader.GetByte(14) == 1 ? true : false;
                    user.is_manager = sqlDataReader.GetByte(15) == 1 ? true : false;
                }

                //close all connections
                sqlDataReader.Close();
                command.Dispose();
                sqlConnection.Close();

                ActionResult res = user.personal_id !=null ? Ok(user) : NotFound();
                logger.Info($"Received Request: 'getJobTitles'. Result: {res}");
                return res;
            }
            catch (Exception e) {
                logger.Error($"Received Request: 'getJobTitles'. Error: {e.Message}");
                return BadRequest(e.Message);
            }
        }

        [HttpPost]
        [Route("createPOSAccount/{personalId}/{password}")]
        public ActionResult createPOSAccount(string personalId,string password)
        {
            //used for loggin information and errors
            XmlConfigurator.ConfigureAndWatch(new FileInfo(Configurations.GetConfiguration("log4netFilename")));

            //create connection to the database
            try {
                SqlConnection sqlConnection = new SqlConnection(Configurations.GetConfiguration("DBConnectionString"));

                String query = $"exec dbo.createPOSAccount {personalId},{password}";

                sqlConnection.Open();

                SqlCommand command = new SqlCommand(query, sqlConnection);

                //execute query
                int rowsAffected = command.ExecuteNonQuery();

                //close all connections
                command.Dispose();
                sqlConnection.Close();

                ActionResult res = rowsAffected > 0 ? Ok() : BadRequest();
                logger.Info($"Received Request: 'createPOSAccount/{personalId}/{password}'. Result: {res}");
                return res;
            }
            catch (Exception e) {
                logger.Error($"Received Request: 'createPOSAccount/{personalId}/{password}'. Error: {e.Message}");
                return BadRequest(e.Message);
            }
        }

        [HttpPost]
        [Route("createManagerAccount/{personalId}/{username}/{password}")]
        public ActionResult createManagerAccount(string personalId, string username, string password)
        {
            //used for loggin information and errors
            XmlConfigurator.ConfigureAndWatch(new FileInfo(Configurations.GetConfiguration("log4netFilename")));

            //create connection to the database
            try {
                SqlConnection sqlConnection = new SqlConnection(Configurations.GetConfiguration("DBConnectionString"));

                String query = $"exec dbo.createManagerAccount {personalId},{username},{password}";

                sqlConnection.Open();

                SqlCommand command = new SqlCommand(query, sqlConnection);

                //execute query
                int rowsAffected = command.ExecuteNonQuery();

                //close all connections
                command.Dispose();
                sqlConnection.Close();

                ActionResult res = rowsAffected > 0 ? Ok() : BadRequest();
                logger.Info($"Received Request: 'createManagerAccount/{personalId}/{password}'. Result: {res}");
                return res;
            }
            catch (Exception e) {
                logger.Error($"Received Request: 'createManagerAccount/{personalId}/{password}'. Error: {e.Message}");
                return BadRequest(e.Message);
            }
        }
    }
}
