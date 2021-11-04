using hmart.DAL;
using hmart.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace hmart.Controllers
{
    public class ShopController : Controller
    {
        private readonly AppDbContext _context;

        public ShopController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Detail()
        {
            return View();
        }

        public IActionResult GetDetail(int id)
        {
            Product product = _context.Products
                .Include(x => x.ProImages)
                .Include(x => x.Reviews)
                .Include(x => x.Category)
                .Include(x => x.ProductTagProducts).ThenInclude(x=>x.ProductTag)
                .FirstOrDefault(x=>x.Id == id);

            if (product == null) return Json(new { statusCode = 404 });

            return PartialView("_DetailPartial",product);
        }
    }
}
