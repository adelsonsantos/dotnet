using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PrimeiraAplicacao.Models;

namespace DefaultNamespace
{
    public class ProductController  : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            using (MyDatabaseEntities dc = new MyDatabaseEntities())
            {
                var products = dc.Product.ToList();
                return Content(products);
            }

        }
    }
}