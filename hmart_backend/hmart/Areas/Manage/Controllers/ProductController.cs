using hmart.DAL;
using hmart.Helpers;
using hmart.Models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace hmart.Areas.Manage.Controllers
{
    [Area("Manage")]
    //[Authorize(Roles = "SuperAdmin,Admin,EditorAdmin")]
    public class ProductController : Controller
    {
        private readonly AppDbContext _context;
        private readonly IWebHostEnvironment _env;

        public ProductController(AppDbContext context, IWebHostEnvironment env)
        {
            _context = context;
            _env = env;
        }
        public IActionResult Index()
        {
            List<Product> products = _context.Products.ToList();

            return View(products);
        }
        public IActionResult Create()
        {
            ViewBag.Categories = _context.Categories.ToList();
            ViewBag.Brands = _context.Brands.ToList();
            ViewBag.Tags = _context.ProductTags.ToList();
            ViewBag.Colors = _context.Colors.ToList();
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Product product)
        {
            ViewBag.Categories = _context.Categories.ToList();
            ViewBag.Brands = _context.Brands.ToList();
            ViewBag.Tags = _context.ProductTags.ToList();
            ViewBag.Colors = _context.Colors.ToList();

            if (!ModelState.IsValid) return View();

            if (!_context.Categories.Any(x => x.Id == product.CategoryId))
            {
                ModelState.AddModelError("CategoryId", "Have not Category like this name!");
                return View();
            }

            if (!_context.Brands.Any(x => x.Id == product.BrandId))
            {
                ModelState.AddModelError("BrandId", "Have not Brand like this name!");
                return View();
            }

            if (_context.Products.Any(x => x.Code == product.Code))
            {
                ModelState.AddModelError("Code", "Code is required!");
                return View();
            }

            #region ImageChack

            if (product.PosterImage == null)
            {
                ModelState.AddModelError("PosterImage", "Poster image can not be null!");
                return View();
            }

            if (product.HoverPosterImage == null)
            {
                ModelState.AddModelError("PosterImage", "Hover Poster image can not be null!");
                return View();
            }

            if (product.PosterImage.ContentType != "image/jpeg" && product.PosterImage.ContentType != "image/png")
            {
                ModelState.AddModelError("PosterImage", "You can choose file only .jpg, .jpeg or .png format!");
                return View();
            }

            if (product.PosterImage.Length > 5242880)
            {
                ModelState.AddModelError("PosterImage", "You can choose file only maximum 5Mb !");
                return View();
            }

            if (product.HoverPosterImage.ContentType != "image/jpeg" && product.HoverPosterImage.ContentType != "image/png")
            {
                ModelState.AddModelError("HoverPosterImage", "You can choose file only .jpg, .jpeg or .png format!");
                return View();
            }

            if (product.HoverPosterImage.Length > 5242880)
            {
                ModelState.AddModelError("HoverPosterImage", "You can choose file only maximum 5Mb !");
                return View();
            }

            if (product.Images != null)
            {
                foreach (var item in product.Images)
                {
                    if (item.ContentType != "image/jpeg" && item.ContentType != "image/png")
                    {
                        ModelState.AddModelError("Images", "You can choose file only .jpg, .jpeg or .png format!");
                        return View();
                    }

                    if (item.Length > 5242880)
                    {
                        ModelState.AddModelError("Images", "You can choose file only maximum 5Mb !");
                        return View();
                    }
                }
            }

            #endregion


            #region ImageUpload

            product.ProImages = new List<ProImage>();
            product.ProductTagProducts = new List<ProductTagProduct>();

            ProImage posterImage = new ProImage()
            {
                PosterStatus = true,
                Image = FileManager.Save(_env.WebRootPath, "uploads/products", product.PosterImage)
            };

            product.ProImages.Add(posterImage);

            ProImage hoverPosterImage = new ProImage()
            {
                PosterStatus = false,
                Image = FileManager.Save(_env.WebRootPath, "uploads/products", product.HoverPosterImage)
            };

            product.ProImages.Add(hoverPosterImage);


            foreach (var item in product.Images)
            {
                ProImage productImage = new ProImage()
                {
                    PosterStatus = null,
                    Image = FileManager.Save(_env.WebRootPath, "uploads/products", item)
                };

                product.ProImages.Add(productImage);
            }

            if (product.TagIds != null)
            {
                foreach (var item in product.TagIds)
                {
                    ProductTagProduct productTag = new ProductTagProduct()
                    {
                        ProductTagId = item
                    };

                    product.ProductTagProducts.Add(productTag);
                }
            }

            #endregion

            _context.Products.Add(product);

            try
            {
                _context.SaveChanges();
            }
            catch (Exception)
            {
                foreach (var item in product.ProImages)
                {
                    FileManager.Delete(_env.WebRootPath, "uploads/books", item.Image);
                }
            }

            return RedirectToAction("index");
        }

        public IActionResult Edit(int id)
        {
            Product product = _context.Products.Include(x => x.ProImages).Include(x => x.ProductTagProducts).FirstOrDefault(x => x.Id == id);


            product.TagIds = product.ProductTagProducts.Select(x => x.ProductTagId).ToList();

            if (product == null) return View("NotFoundPage");

            ViewBag.Categories = _context.Categories.ToList();
            ViewBag.Brands = _context.Brands.ToList();
            ViewBag.Colors = _context.Colors.ToList();
            ViewBag.Tags = _context.ProductTags.ToList();

            return View(product);
        }
    }
}
