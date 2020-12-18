using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Migrations;
using WarehouseManagement1.Data;
using WarehouseManagement1.Models;

namespace WarehouseManagement1.Controllers
{
    public class StockController : Controller
    {

        private ApplicationDbContext _dbContext;


     //   public StockController(ApplicationDbContext dbContext)
     //   {
       //     _dbContext = dbContext;
      //  }

        public StockController()
        {
            _dbContext = new ApplicationDbContext();
        }


        public IActionResult StockList()
        {
            //var stock = new Stock() { Name = "Moersleutel", Id = 1 };

            return View(); 
        }

   //     public IActionResult Test()
    //    {
    //        var user = _dbContext.Users.First();
    //        return Ok(user);
   //     }

        public IActionResult SeedDb()
        {
            var newStock = new Stock
            {
                Name = "Sjoerd"
            };

            _dbContext.Stocks.Add(newStock);
            _dbContext.SaveChanges();

            return Ok(newStock);
        }

        public IActionResult Index()
        {
            var stock = _dbContext.Stocks;
            return View(stock);
        }


    }
}
