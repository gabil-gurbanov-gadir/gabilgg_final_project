using hmart.DAL;
using hmart.Models;
using hmart.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace hmart.Controllers
{
    public class HomeController : Controller
    {
        private readonly AppDbContext _context;

        public HomeController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            HomeVM homeVM = new HomeVM
            {
                Setting = _context.Settings.FirstOrDefault(),
                Sliders = _context.Sliders.Take(4).ToList(),
                MainBanner = _context.Banners.FirstOrDefault(x => x.IsMain),
                Banners = _context.Banners.Where(x => x.IsMain == false).Take(2).ToList(),
                NewProducts = _context.Products
                .Include(x=>x.ProImages)
                .Include(x=>x.Category)
                .OrderByDescending(x => x.CreatedAt).Take(8).ToList(),
                TopRatedProducts = _context.Products.OrderByDescending(x => x.Rate).Take(8).ToList(),
                FeaturedProducts = _context.Products.Where(x => x.IsOnOffer).Take(8).ToList(),
                MainOffer = _context.Offers.Include(x => x.Product).FirstOrDefault(x => x.IsMain),
                Offers = _context.Offers.Where(x=>x.IsMain==false).Include(x=>x.Product).Take(2).ToList(),
                Testimonials = _context.Testimonials.Take(5).ToList(),
                Partners = _context.Partners.Take(8).ToList(),
                Blogs = _context.Blogs.OrderByDescending(x => x.Date).Take(2).ToList()
            };

            return View(homeVM);
        }

        public IActionResult About()
        {
            return View();
        }
        public IActionResult Contact()
        {
            return View();
        }
    }
}
