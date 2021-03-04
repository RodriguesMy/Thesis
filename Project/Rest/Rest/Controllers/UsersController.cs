using Microsoft.AspNetCore.Mvc;
using Rest.SharedClasses;
using System;
using System.Configuration;
using System.Data.SqlClient;

namespace Rest.Controllers
{
    public class UsersController : Controller
    {

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        [Route("checkPassword/{pin}")]
        public ActionResult CheckCredentials(String pin)
        {
            //create connection to the database
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

            return linesReceived > 0 ? Ok() : NotFound(); 
        }

    }
}
