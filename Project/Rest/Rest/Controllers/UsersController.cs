using log4net;
using log4net.Config;
using Microsoft.AspNetCore.Mvc;
using Rest.SharedClasses;
using System;
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
                return BadRequest();
            }      
        }
    }
}
