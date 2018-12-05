using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Data;
using System.Web;
using System.Data.SqlClient;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PrimeiraAplicacao.Models;

namespace PrimeiraAplicacao.Controllers
{
    public class HomeController : Controller
    {
        private string connectionString =
            @"Data Source = (local)\sqle2017; Initial Catalog = Mydatabase; Integrated Security=True";  
        [HttpGet]
        public IActionResult Index()
        {
            DataTable dtblProduct = new DataTable();
            using (SqlConnection sqlCon = new SqlConnection(ConnectionString))
            {
                sqlCon.Open();
                SqlDataAdapter sqlDa = new SqlDataAdapter("Select * from Product, sqlCon");
                sqlDa.Fill(dtblProduct);_
            }
            return View(dtblProduct);
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";          

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
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
