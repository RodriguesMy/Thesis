using log4net;
using log4net.Config;
using Microsoft.AspNetCore.Cors;
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
    public class OrdersController : Controller
    {
        private static readonly ILog logger = LogManager.GetLogger(typeof(OrdersController));
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        [Route("createOrder/{cashierID}/{paymentMethod}/{discount_applied}")]
        public ActionResult createOrder(String cashierID, String paymentMethod,String discount_applied)
        {
            //used for loggin information and errors
            XmlConfigurator.ConfigureAndWatch(new FileInfo(Configurations.GetConfiguration("log4netFilename")));

            //create connection to the database
            try {
                SqlConnection sqlConnection = new SqlConnection(Configurations.GetConfiguration("DBConnectionString"));
                String query = $"exec dbo.createReceipt {cashierID},{paymentMethod},{discount_applied}" ;
                sqlConnection.Open();

                SqlCommand command = new SqlCommand(query, sqlConnection);

                //execute query
                SqlDataReader sqlDataReader = command.ExecuteReader();
                long identity = 0;
                while (sqlDataReader.Read()) {
                    identity = sqlDataReader.GetInt64(0);
                }

                //close all connections
                sqlDataReader.Close();
                command.Dispose();
                sqlConnection.Close();

                ActionResult res = identity != 0 ? Ok(identity) : BadRequest();
                logger.Info($"Received Request: 'createOrder/{cashierID}/{paymentMethod}'. Result: {res}");
                return res;
            }
            catch (Exception e) {
                logger.Error($"Received Request: 'createOrder/{cashierID}/{paymentMethod}'. Error: {e.Message}");
                return BadRequest(e.Message);
            }
        }

        [HttpPost]
        [Route("insertItemInOrder/{receipt_id}/{item_id}/{qty}")]
        public ActionResult insertItemInOrder(String receipt_id, String item_id,String qty)
        {
            //used for loggin information and errors
            XmlConfigurator.ConfigureAndWatch(new FileInfo(Configurations.GetConfiguration("log4netFilename")));

            //create connection to the database
            try {
                SqlConnection sqlConnection = new SqlConnection(Configurations.GetConfiguration("DBConnectionString"));
                String query = $"exec dbo.insertItemToReceipt {receipt_id},{item_id},{qty}";
                sqlConnection.Open();

                SqlCommand command = new SqlCommand(query, sqlConnection);

                //execute query
                ActionResult res = command.ExecuteNonQuery() > 0 ? Ok() : BadRequest();

                //close all connections
                command.Dispose();
                sqlConnection.Close();
            
                logger.Info($"Received Request: 'insertItemInOrder/{receipt_id}/{item_id}/{qty}'. Result: {res}");
                return res;
            }
            catch (Exception e) {
                logger.Error($"Received Request: 'insertItemInOrder/{receipt_id}/{item_id}/{qty}'. Error: {e.Message}");
                return BadRequest(e.Message);
            }
        }

        [HttpGet]
        [Route("getAllTodaysOrders")]
        public ActionResult getAllTodaysOrders()
        {
            //used for loggin information and errors
            XmlConfigurator.ConfigureAndWatch(new FileInfo(Configurations.GetConfiguration("log4netFilename")));

            //create connection to the database
            try {
                SqlConnection sqlConnection = new SqlConnection(Configurations.GetConfiguration("DBConnectionString"));
                String query = $"exec dbo.getAllTodaysOrders";
                sqlConnection.Open();

                SqlCommand command = new SqlCommand(query, sqlConnection);

                // execute query
                SqlDataReader sqlDataReader = command.ExecuteReader();
                Dictionary<long,decimal> results = new Dictionary<long, decimal>();
                while (sqlDataReader.Read()) {
                    results.Add(sqlDataReader.GetInt64(0),sqlDataReader.GetDecimal(1));
                }

                //close all connections
                sqlDataReader.Close();
                command.Dispose();
                sqlConnection.Close();

                logger.Info($"Received Request: 'getAllTodaysOrders'. Result: {results}");
                return Ok(results);
            }
            catch (Exception e) {
                logger.Error($"Received Request: 'getAllTodaysOrders'. Error: {e.Message}");
                return BadRequest(e.Message);
            }
        }

        [HttpGet]
        [Route("getOrderById/{orderId}")]
        public ActionResult getOrderById(String orderId)
        {
            //used for loggin information and errors
            XmlConfigurator.ConfigureAndWatch(new FileInfo(Configurations.GetConfiguration("log4netFilename")));

            //create connection to the database
            try {
                SqlConnection sqlConnection = new SqlConnection(Configurations.GetConfiguration("DBConnectionString"));
                String query = $"exec dbo.getOrderById " +orderId;
                sqlConnection.Open();

                SqlCommand command = new SqlCommand(query, sqlConnection);

                // execute query
                SqlDataReader sqlDataReader = command.ExecuteReader();
                List<ReceiptContents> receptContents = new List<ReceiptContents>();
                while (sqlDataReader.Read()) {
                    receptContents.Add(
                        new ReceiptContents(
                            sqlDataReader.GetInt32(0).ToString(),
                            sqlDataReader.GetString(1).Trim(),
                            sqlDataReader.GetDecimal(2).ToString("N2"),
                            sqlDataReader.GetInt16(3).ToString()
                        ));
                }

                //close all connections
                sqlDataReader.Close();
                command.Dispose();
                sqlConnection.Close();

                logger.Info($"Received Request: 'getOrderById/{orderId}'. Result: {receptContents}");
                return Ok(receptContents);
            }
            catch (Exception e) {
                logger.Error($"Received Request: 'getOrderById/{orderId}'. Error: {e.Message}");
                return BadRequest(e.Message);
            }
        }

        [HttpPost]
        [Route("modifyReceipt/{orderId}/{paymentMethod}/{discount}")]
        public ActionResult modifyReceipt(String orderId, String paymentMethod,String discount)
        {
            //used for loggin information and errors
            XmlConfigurator.ConfigureAndWatch(new FileInfo(Configurations.GetConfiguration("log4netFilename")));

            //create connection to the database
            try {
                SqlConnection sqlConnection = new SqlConnection(Configurations.GetConfiguration("DBConnectionString"));
                String query = $"exec dbo.modifyReceipt {orderId},{paymentMethod},{discount}";
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

                ActionResult res = linesReceived > 0 ? Ok() : BadRequest();
                logger.Info($"Received Request: 'modifyReceipt/{orderId}/{paymentMethod}/{discount}'. Result: {res}");
                return res;
            }
            catch (Exception e) {
                logger.Error($"Received Request: 'modifyReceipt/{orderId}/{paymentMethod}/{discount}'. Error: {e.Message}");
                return BadRequest(e.Message);
            }
        }

        [HttpPost]
        [Route("removeReceiptContents/{orderId}")]
        public ActionResult removeReceiptContents(String orderId)
        {
            //used for loggin information and errors
            XmlConfigurator.ConfigureAndWatch(new FileInfo(Configurations.GetConfiguration("log4netFilename")));

            //create connection to the database
            try {
                SqlConnection sqlConnection = new SqlConnection(Configurations.GetConfiguration("DBConnectionString"));
                String query = $"exec dbo.removeReceiptContents {orderId}";
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

                ActionResult res = linesReceived > 0 ? Ok() : BadRequest();
                logger.Info($"Received Request: 'removeReceiptContents/{orderId}'. Result: {res}");
                return res;
            }
            catch (Exception e) {
                logger.Error($"Received Request: 'removeReceiptContents/{orderId}'. Error: {e.Message}");
                return BadRequest(e.Message);
            }
        }
    }
}
