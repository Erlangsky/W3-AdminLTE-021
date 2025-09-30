using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace NET_MVC___Admin_LTE.Controllers
{
    public class Login : Controller
    {
        private readonly ILogger<Login> _logger;

        public Login(ILogger<Login> logger)
        {
            _logger = logger;
        }

       // GET: halaman login
        [HttpGet]
        public IActionResult Logins()
        {
            return View();
        }

        // POST: proses login
        [HttpPost]
        public IActionResult Logins(string email, string password)
        {
            // contoh validasi sederhana (hardcode)
            if (email == "admin@gmail.com" && password == "123")
            {
                // redirect ke dashboard kalau benar
                return RedirectToAction("Index", "Dashboard");
            }

            // kalau salah → kirim error ke View
            ViewBag.Error = "Email atau password salah!";
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View("Error!");
        }
    }
}