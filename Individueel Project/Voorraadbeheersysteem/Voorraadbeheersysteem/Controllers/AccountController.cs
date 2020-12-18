using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Voorraadbeheersysteem.Models;

namespace Voorraadbeheersysteem.Controllers
{
    public class AccountController : Controller
    {
        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }

        public IActionResult Verify(Account account)
        {
            return View();
        }
    }
}
