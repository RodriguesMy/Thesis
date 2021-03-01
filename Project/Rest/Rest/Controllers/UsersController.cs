using Microsoft.AspNetCore.Mvc;
using System;
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
            SqlConnection sqlConnection = new SqlConnection();
            sqlConnection.ConnectionString = 
                "Data Source=localhost\\MSSQLSERVER07;"+
                "Initial Catalog = POS;"+
                "Integrated Security = True" ;
            String query = "exec dbo.validateUser " + pin;
            sqlConnection.Open();

            SqlCommand command = new SqlCommand(query, sqlConnection);

            SqlDataReader sqlDataReader = command.ExecuteReader();
            int linesReceived = 0;
            while (sqlDataReader.Read()) {
                linesReceived++;
            }
            sqlDataReader.Close();
            command.Dispose();
            sqlConnection.Close();
            return linesReceived > 0 ? Ok() : NotFound(); 
        }

    }
}
