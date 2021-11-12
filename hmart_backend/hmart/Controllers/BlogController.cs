using hmart.DAL;
using hmart.Models;
using hmart.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace hmart.Controllers
{
    public class BlogController : Controller
    {
        private readonly AppDbContext _context;

        public BlogController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index(int? tagId)
        {
            var query = _context.Blogs.AsQueryable();

            if (tagId != null)
            {
                query = query.Where(x => x.BlogTagBlogs.Any(x => x.BlogTagId == tagId));
            }

            int totalBlogs = query.Count();

            BlogVM blogVM = new BlogVM
            {
                Setting = _context.Settings.FirstOrDefault(),

                SelectedPage = 1,
                TotalPages = (int)Math.Ceiling(totalBlogs / 9d),
                TotalBlogs = totalBlogs,
                TagId = tagId,
                Blogs = query.Take(9).ToList()
            };

            return View(blogVM);
        }

        public IActionResult Pagenation(int? tagId, int page = 1)
        {
            var query = _context.Blogs.AsQueryable();

            if (tagId != null)
            {
                query = query.Where(x => x.BlogTagBlogs.Any(x => x.BlogTagId == tagId));
            }

            int totalBlogs = query.Count();

            PaginationBlogVM paginationBlogVM = new PaginationBlogVM
            {
                SelectedPage = 1,
                TotalPages = (int)Math.Ceiling(totalBlogs / 9d),
                TotalBlogs = totalBlogs,
                TagId = tagId,
                Blogs = query.Include(x=>x.BlogTagBlogs).ThenInclude(x=>x.BlogTag)
                .Take(9).ToList()
            };

            return PartialView("_BlogsPartial", paginationBlogVM);
        }

        public IActionResult Detail()
        {
            return View();
        }
    }
}
