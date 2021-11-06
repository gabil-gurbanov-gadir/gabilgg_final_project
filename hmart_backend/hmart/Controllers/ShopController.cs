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
                TotalPrice = 0,
                IsAddBtn=true
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

                List<BasketCookieItemVM> basketCookieItemVMs = new List<BasketCookieItemVM>();

                if (basket == null)
                {
                    basketCookieItemVMs = new List<BasketCookieItemVM>()
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
                    basketCookieItemVMs = JsonConvert.DeserializeObject<List<BasketCookieItemVM>>(basket);
                    BasketCookieItemVM basketCookieItemVM = basketCookieItemVMs.FirstOrDefault(x => x.ProductId == product.Id);
                    if (basketCookieItemVM == null)
                    {
                        basketCookieItemVM = new BasketCookieItemVM()
                        {
                            ProductId = product.Id,
                            Count = 1
                        };
                        basketCookieItemVMs.Add(basketCookieItemVM);
                    }
                    else
                    {
                        basketCookieItemVM.Count++;
                    }
                }

                var basketCookieItemsStr = JsonConvert.SerializeObject(basketCookieItemVMs);

                HttpContext.Response.Cookies.Append("Basket", basketCookieItemsStr);

                foreach (var item in basketCookieItemVMs)
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

        public IActionResult DeleteFromBasket(int id)
        {
            Product product = _context.Products.Include(x => x.BasketItems).FirstOrDefault(b => b.Id == id);

            BasketVM basketData = new BasketVM()
            {
                BasketItemVMs = new List<BasketItemVM>(),
                TotalPrice = 0,
                IsAddBtn = false
            };

            if (User.Identity.IsAuthenticated && _userManager.Users.Any(x => x.UserName == User.Identity.Name && x.IsAdmin == false))
            {
                AppUser user = _userManager.FindByNameAsync(User.Identity.Name).Result;

                BasketItem basketItem = product.BasketItems.FirstOrDefault(x => x.AppUserId == user.Id);
                if (basketItem.Count > 1)
                {
                    basketItem.Count--;
                }
                else
                {
                    product.BasketItems.RemoveAll(x => x.AppUserId == user.Id);
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
                            basketData.TotalPrice += (double)((basketItemVM.Product.Price - basketItemVM.Product.Price * basketItemVM.Product.DiscountPercent / 100) * basketItemVM.Count);
                        }
                        basketData.BasketItemVMs.Add(basketItemVM);
                        basketData.Count++;
                    }
                }
            }
            else
            {
                var basket = HttpContext.Request.Cookies["Basket"];
                List<BasketCookieItemVM> basketCookieItemVMs;


                basketCookieItemVMs = JsonConvert.DeserializeObject<List<BasketCookieItemVM>>(basket);

                BasketCookieItemVM basketItemVM = basketCookieItemVMs.FirstOrDefault(x => x.ProductId == id);

                if (basketItemVM.Count > 1)
                {
                    basketCookieItemVMs.FirstOrDefault(x => x.ProductId == id).Count--;
                }
                else
                {
                    basketCookieItemVMs.RemoveAll(x => x.ProductId == id);
                }

                var basketCookieItemsStr = JsonConvert.SerializeObject(basketCookieItemVMs);
                HttpContext.Response.Cookies.Append("Basket", basketCookieItemsStr);



                foreach (var item in basketCookieItemVMs)
                {
                    BasketItemVM basketItemVMForCookie = new BasketItemVM()
                    {
                        Product = _context.Products.Include(x => x.ProImages).FirstOrDefault(x => x.Id == item.ProductId),
                        Count = item.Count
                    };

                    if (basketItemVMForCookie.Product != null)
                    {
                        if (basketItemVMForCookie.Product.DiscountPercent == null)
                        {
                            basketData.TotalPrice += basketItemVMForCookie.Product.Price * basketItemVMForCookie.Count;
                        }
                        else
                        {
                            basketData.TotalPrice += (double)((basketItemVMForCookie.Product.Price - basketItemVMForCookie.Product.Price * basketItemVMForCookie.Product.DiscountPercent / 100) * basketItemVMForCookie.Count);
                        }
                        basketData.BasketItemVMs.Add(basketItemVMForCookie);
                        basketData.Count++;
                    }

                }
            }

            return PartialView("_BasketPartial", basketData);
        }
    }
}
