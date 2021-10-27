using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace hmart.Controllers
{
    public class AccountController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Login()
        {
            return View();
        }

        public IActionResult Logout()
        {
            return RedirectToAction("Login");
        }

        public IActionResult Register()
        {
            return View();
        }

        public IActionResult Cart()
        {
            return View();
        }

        public IActionResult Wishlist()
        {
            return View();
        }

        public IActionResult Checkout()
        {
            return View();
        }
    }
}
