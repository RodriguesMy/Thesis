using log4net;
using log4net.Config;
using Microsoft.AspNetCore.Mvc;
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
    public class ItemsController : Controller
    {
        private static readonly ILog logger = LogManager.GetLogger(typeof(ItemsController));

        List<ItemType> types = new List<ItemType>();
        List<ItemCategory> categories = new List<ItemCategory>();
        List<Item> items = new List<Item>();
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        [Route("getCategories")]
        public ActionResult getCategories()
        {
            //used for loggin information and errors
            XmlConfigurator.ConfigureAndWatch(new FileInfo(Configurations.GetConfiguration("log4netFilename")));

            try {
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
                ActionResult res = Ok(categories);
                logger.Info($"Received Request: 'getCategories'. Result: {res}");
                return res;
            }catch(Exception e) {
                logger.Error($"Received Request: 'getCategories'. Result: {e.Message}");
                return BadRequest(e.Message);
            }
        }

        [HttpGet]
        [Route("getItemTypes")]
        public ActionResult getItemTypes()
        {
            //used for loggin information and errors
            XmlConfigurator.ConfigureAndWatch(new FileInfo(Configurations.GetConfiguration("log4netFilename")));

            try {
                if (items == null || items.Count == 0) {
                    //create connection to the database
                    SqlConnection sqlConnection = new SqlConnection(Configurations.GetConfiguration("DBConnectionString"));
                    String query = "exec dbo.getAllItemTypes";
                    sqlConnection.Open();

                    SqlCommand command = new SqlCommand(query, sqlConnection);

                    //execute query
                    SqlDataReader sqlDataReader = command.ExecuteReader();

                    while (sqlDataReader.Read()) {
                        types.Add(new ItemType(sqlDataReader.GetInt16(0), sqlDataReader.GetString(1).Trim(), sqlDataReader.GetInt16(2)));
                    }

                    //close all connections
                    sqlDataReader.Close();
                    command.Dispose();
                    sqlConnection.Close();
                }

                ActionResult res = Ok(types);
                logger.Info($"Received Request: 'getItemTypes'. Result: {res}");
                return res;
            }
            catch(Exception e) {
                logger.Error($"Received Request: 'getItemTypes'. Result: {e.Message}");
                return BadRequest(e.Message);
            }
        }

        [HttpGet]
        [Route("getItems/{item_type}")]
        public ActionResult getItems(int item_type)
        {
            //used for loggin information and errors
            XmlConfigurator.ConfigureAndWatch(new FileInfo(Configurations.GetConfiguration("log4netFilename")));

            try {
                if (types == null || types.Count == 0) {
                    //create connection to the database
                    SqlConnection sqlConnection = new SqlConnection(Configurations.GetConfiguration("DBConnectionString"));
                    String query = "exec dbo.getItemsOfType " + item_type;
                    sqlConnection.Open();

                    SqlCommand command = new SqlCommand(query, sqlConnection);

                    //execute query
                    SqlDataReader sqlDataReader = command.ExecuteReader();

                    while (sqlDataReader.Read()) {
                        int ID = sqlDataReader.GetInt32(0);
                        string name = sqlDataReader.GetString(1);
                        Decimal price = sqlDataReader.GetDecimal(2);
                        int item_category = sqlDataReader.GetInt16(4);
                        items.Add(new Item(ID, name, price, item_type, item_category));
                    }

                    //close all connections
                    sqlDataReader.Close();
                    command.Dispose();
                    sqlConnection.Close();
                }
                ActionResult res = Ok(items);
                logger.Info($"Received Request: 'getItems/{item_type}'. Result: {res}");
                return res;
            }catch(Exception e) {
                logger.Error($"Received Request: 'getItems/{item_type}'. Result: {e.Message}");
                return BadRequest(e.Message);
            }
        }
    }
}
