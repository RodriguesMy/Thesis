using Microsoft.AspNetCore.Mvc;
using Rest.Models;
using Rest.SharedClasses;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace Rest.Controllers
{
    public class ItemsController : Controller
    {
        List<ItemType> categories = new List<ItemType>();

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        [Route("getCategories")]
        public ActionResult CheckCredentials(String pin)
        {
            if (categories == null || categories.Count == 0) {
                //create connection to the database
                SqlConnection sqlConnection = new SqlConnection(Configurations.GetConfiguration("DBConnectionString"));
                String query = "exec dbo.getAllCategories";
                sqlConnection.Open();

                SqlCommand command = new SqlCommand(query, sqlConnection);

                //execute query
                SqlDataReader sqlDataReader = command.ExecuteReader();

                while (sqlDataReader.Read()) {
                    categories.Add(new ItemType(sqlDataReader.GetInt16(0), sqlDataReader.GetString(1).Trim()));
                }

                //close all connections
                sqlDataReader.Close();
                command.Dispose();
                sqlConnection.Close();
            }

            return Ok(categories);
        }
    }
}
