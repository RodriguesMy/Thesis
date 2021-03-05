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
        List<ItemType> types = new List<ItemType>();
        List<ItemCategory> categories = new List<ItemCategory>();
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        [Route("getCategories")]
        public ActionResult getCategories()
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
                    categories.Add(new ItemCategory(sqlDataReader.GetInt16(0), sqlDataReader.GetString(1).Trim()));
                }

                //close all connections
                sqlDataReader.Close();
                command.Dispose();
                sqlConnection.Close();
            }

            return Ok(categories);
        }

        [HttpGet]
        [Route("getItemTypes")]
        public ActionResult getItemTypes()
        {
            if (types == null || types.Count == 0) {
                //create connection to the database
                SqlConnection sqlConnection = new SqlConnection(Configurations.GetConfiguration("DBConnectionString"));
                String query = "exec dbo.getAllItemTypes";
                sqlConnection.Open();

                SqlCommand command = new SqlCommand(query, sqlConnection);

                //execute query
                SqlDataReader sqlDataReader = command.ExecuteReader();

                while (sqlDataReader.Read()) {
                    types.Add(new ItemType(sqlDataReader.GetInt16(0), sqlDataReader.GetString(1).Trim(),sqlDataReader.GetInt16(2)));
                }

                //close all connections
                sqlDataReader.Close();
                command.Dispose();
                sqlConnection.Close();
            }

            return Ok(types);
        }
    }
}
