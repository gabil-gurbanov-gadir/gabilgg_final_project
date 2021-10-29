﻿using hmart.DAL;
using hmart.Helpers;
using hmart.Models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace hmart.Areas.Manage.Controllers
{
    [Area("Manage")]
    //[Authorize(Roles = "SuperAdmin,Admin,EditorAdmin")]
    public class TeamController : Controller
    {
        private readonly AppDbContext _context;
        private readonly IWebHostEnvironment _env;

        public TeamController(AppDbContext context, IWebHostEnvironment env)
        {
            _context = context;
            _env = env;
        }
        public IActionResult Index()
        {
            List<Team> teams = _context.Teams.ToList();

            return View(teams);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Team team)
        {
            Team newTeam = new Team
            {
                Fullname = team.Fullname,
                Position = team.Position,
                Order = team.Order
            };

            if (team.ImageFile != null)
            {
                if (team.ImageFile.ContentType != "image/jpeg" && team.ImageFile.ContentType != "image/png")
                {
                    ModelState.AddModelError("ImageFile", "You can choose file only .jpg, .jpeg or .png format!");
                    return View();
                }

                if (team.ImageFile.Length > 5242880)
                {
                    ModelState.AddModelError("ImageFile", "You can choose file only maximum 5Mb !");
                    return View();
                }

                newTeam.Image = FileManager.Save(_env.WebRootPath, "uploads/teams", team.ImageFile);
            }

            _context.Teams.Add(newTeam);

            try
            {
                _context.SaveChanges();
            }
            catch (Exception)
            {
                FileManager.Delete(_env.WebRootPath, "uploads/teams", newTeam.Image);
            }

            return RedirectToAction("Index");
        }

        public IActionResult Edit(int id)
        {
            Team team = _context.Teams.FirstOrDefault(x => x.Id == id);

            if (team == null) return View("NotFoundPage");

            return View(team);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(Team tm)
        {
            if (!ModelState.IsValid) return View();

            Team team = _context.Teams.FirstOrDefault(x => x.Id == tm.Id);

            if (team == null) return View("NotFoundPage");

            team.Fullname = tm.Fullname;
            team.Position = tm.Position;
            team.Order = tm.Order;

            if (tm.ImageFile != null)
            {
                if (tm.ImageFile.ContentType != "image/jpeg" && tm.ImageFile.ContentType != "image/png")
                {
                    ModelState.AddModelError("ImageFile", "Yalniz .jpg , .jpeg ve ya .png formatda fayl sece bilersiz!");
                    return View();
                }
                if (tm.ImageFile.Length > 5242880)
                {
                    ModelState.AddModelError("ImageFile", "Maksimum uzunlugu 5Mb olan fayl sece bilersiz!");
                    return View();
                }

                string newFileName = FileManager.Save(_env.WebRootPath, "uploads/teams", tm.ImageFile);

                if (!string.IsNullOrWhiteSpace(team.Image))
                {
                    FileManager.Delete(_env.WebRootPath, "uploads/teams", team.Image);
                }

                team.Image = newFileName;
            }
            else if (string.IsNullOrWhiteSpace(tm.Image) && !string.IsNullOrWhiteSpace(team.Image))
            {

                FileManager.Delete(_env.WebRootPath, "uploads/teams", team.Image);

                team.Image = null;
            }

            _context.SaveChanges();

            return RedirectToAction("index");
        }

        public IActionResult Delete(int id)
        {
            Team team = _context.Teams.FirstOrDefault(x => x.Id == id);

            if (team == null) return View("NotFoundPage");

            return View(team);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Delete(Team tm)
        {
            if (!ModelState.IsValid) return View();

            Team team = _context.Teams.FirstOrDefault(x => x.Id == tm.Id);

            if (team == null) return View("NotFoundPage");

            if (!string.IsNullOrWhiteSpace(team.Image))
            {
                FileManager.Delete(_env.WebRootPath, "uploads/teams", team.Image);
            }

            _context.Teams.Remove(team);
            _context.SaveChanges();

            return RedirectToAction("index");
        }
    }
}