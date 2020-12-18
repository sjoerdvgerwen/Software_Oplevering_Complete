using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using SqlConnection.Models;
using System.Data.SqlClient;

namespace SqlConnection.Controllers
{
    public class HomeController : Controller
    {

        SqlCommand com = new SqlCommand();
        SqlDataReader dr;
        System.Data.SqlClient.SqlConnection con = new System.Data.SqlClient.SqlConnection();
        List<Address> addresses = new List<Address>();

        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
            con.ConnectionString = SqlConnection.Properties.Resources.ConnectionString;
        }

        public IActionResult Index()
        {
            FetchData();
            return View(addresses);
        }

        private void FetchData()
        {
            if(addresses.Count > 0)
            {
                addresses.Clear();
            }
            try
            {
                con.Open();
                com.Connection = con;
                //com.CommandText = "SELECT * [UserID], [Username], [Password] FROM [stock].[tables].[users]";
                dr = com.ExecuteReader();
                while (dr.Read())
                {
                    addresses.Add(new Address()
                    {
                        UserID = dr["UserID"].ToString()
                    ,
                        UserName = dr["Username"].ToString()
                        ,
                        Password = dr["Password"].ToString()
                    });
                }
                con.Close();
            }
            catch (Exception ex)
            {

                throw;
            }
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
