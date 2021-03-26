using log4net;
using log4net.Config;
using Microsoft.AspNetCore.Mvc;
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
    }
}
