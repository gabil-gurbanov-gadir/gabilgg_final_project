using hmart.DAL;
using hmart.Models;
using hmart.ViewModels;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace hmart.Controllers
{
    public class ShopController : Controller
    {
        private readonly AppDbContext _context;
        private readonly UserManager<AppUser> _userManager;

        public ShopController(AppDbContext context, UserManager<AppUser> userManager)
        {
            _context = context;
            _userManager = userManager;
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


            return PartialView("_DetailPartial",product);
        }

        public IActionResult AddToBasket(int id)
        {
            Product product = _context.Products.Include(x => x.BasketItems).FirstOrDefault(x => x.Id == id);

            BasketVM basketData = new BasketVM()
            {
                BasketItemVMs = new List<BasketItemVM>(),
                TotalPrice = 0
            };

            if (product.Count == 0)
            {
                basketData = null;
                return NoContent();
            }

            if (User.Identity.IsAuthenticated && _userManager.Users.Any(x => x.UserName == User.Identity.Name && x.IsAdmin == false))
            {
                AppUser user = _userManager.FindByNameAsync(User.Identity.Name).Result;

                BasketItem basketItem = product.BasketItems.FirstOrDefault(x => x.AppUserId == user.Id);
                if (basketItem != null)
                {
                    basketItem.Count++;
                }
                else
                {
                    basketItem = new BasketItem
                    {
                        AppUserId = user.Id,
                        Count = 1,
                        ProductId = id
                    };

                    product.BasketItems.Add(basketItem);
                }

                _context.SaveChanges();

                foreach (var item in _context.BasketItems.Include(x => x.AppUser).Include(x => x.Product).ThenInclude(x => x.ProImages).Where(x => x.AppUser.UserName == User.Identity.Name).ToList())
                {
                    BasketItemVM basketItemVM = new BasketItemVM()
                    {
                        Product = _context.Products.Include(x => x.ProImages).FirstOrDefault(x => x.Id == item.ProductId),
                        Count = item.Count
                    };

                    if (basketItemVM.Product != null)
                    {
                        if (basketItemVM.Product.DiscountPercent == null)
                        {
                            basketData.TotalPrice += basketItemVM.Product.Price * basketItemVM.Count;
                        }
                        else
                        {
                            basketData.TotalPrice += (double)((basketItemVM.Product.Price - basketItemVM.Product.Price * basketItemVM.Product.DiscountPercent/100) * basketItemVM.Count);
                        }
                        basketData.BasketItemVMs.Add(basketItemVM);
                        basketData.Count++;
                    }
                }
            }
            else
            {
                var basket = HttpContext.Request.Cookies["Basket"];

                List<BasketCookieItemVM> basketCookieItems = new List<BasketCookieItemVM>();

                if (basket == null)
                {
                    basketCookieItems = new List<BasketCookieItemVM>()
                    {
                        new BasketCookieItemVM()
                        {
                            ProductId = product.Id,
                            Count = 1
                         }
                     };
                }
                else
                {
                    basketCookieItems = JsonConvert.DeserializeObject<List<BasketCookieItemVM>>(basket);
                    BasketCookieItemVM basketCookieItem = basketCookieItems.FirstOrDefault(x => x.ProductId == product.Id);
                    if (basketCookieItem == null)
                    {
                        basketCookieItem = new BasketCookieItemVM()
                        {
                            ProductId = product.Id,
                            Count = 1
                        };
                        basketCookieItems.Add(basketCookieItem);
                    }
                    else
                    {
                        basketCookieItem.Count++;
                    }
                }

                var basketCookieItemsStr = JsonConvert.SerializeObject(basketCookieItems);

                HttpContext.Response.Cookies.Append("Basket", basketCookieItemsStr);

                foreach (var item in basketCookieItems)
                {

                    BasketItemVM basketItem = new BasketItemVM()
                    {
                        Product = _context.Products.Include(x => x.ProImages).FirstOrDefault(x => x.Id == item.ProductId),
                        Count = item.Count
                    };

                    if (basketItem.Product != null)
                    {
                        if (basketItem.Product.DiscountPercent == null)
                        {
                            basketData.TotalPrice += basketItem.Product.Price * basketItem.Count;
                        }
                        else
                        {
                            basketData.TotalPrice += (double)((basketItem.Product.Price - basketItem.Product.Price * basketItem.Product.DiscountPercent / 100) * basketItem.Count);
                        }
                        basketData.BasketItemVMs.Add(basketItem);
                        basketData.Count++;
                    }
                }
            }

            return PartialView("_BasketPartial", basketData);
        }
    }
}
