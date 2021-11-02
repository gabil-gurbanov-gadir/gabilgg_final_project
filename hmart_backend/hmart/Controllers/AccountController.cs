using hmart.DAL;
using hmart.Helpers;
using hmart.Models;
using hmart.Services;
using hmart.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace hmart.Controllers
{
    public class AccountController : Controller
    {

        private readonly AppDbContext _context;
        private readonly UserManager<AppUser> _userManager;
        private readonly SignInManager<AppUser> _signInManager;
        private readonly IWebHostEnvironment _env;
        //private readonly IEmailService _emailService;

        // , ,  IEmailService emailService

        public AccountController(AppDbContext context, UserManager<AppUser> userManager, SignInManager<AppUser> signInManager, IWebHostEnvironment env)
        {
            _context = context;
            _userManager = userManager;
            _signInManager = signInManager;
            _env = env;
            //_emailService = emailService;
        }


        [Authorize(Roles = "Member")]
        public async Task<IActionResult> Detail()
        {
            ViewBag.Setting = _context.Settings.FirstOrDefault();

            AppUser user = await _userManager.FindByNameAsync(User.Identity.Name);

            AccountDetailVM accountDetailVM = new AccountDetailVM
            {
                FirstName = user.FisrtName,
                LastName = user.LastName,
                UserName = user.UserName,
                Email = user.Email,
                Image = user.Image,
                Gender = user.Gender,
                BirthDay = user.BirthDay
            };

            return View(accountDetailVM);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Detail(AccountDetailVM accountDetailVM)
        {
            ViewBag.Setting = _context.Settings.FirstOrDefault();

            AppUser user = await _userManager.FindByNameAsync(User.Identity.Name);

            if (!ModelState.IsValid) return View(accountDetailVM);

            if (_userManager.Users.Any(x => x.NormalizedUserName == accountDetailVM.UserName.ToUpper()))
            {
                ModelState.AddModelError("UserName", "This username is using!");
                return View();
            }

            if (_userManager.Users.Any(x => x.NormalizedEmail == accountDetailVM.Email.ToUpper()))
            {
                ModelState.AddModelError("Email", "This email is using!");
                return View();
            }

            if (accountDetailVM.Password != null)
            {
                if (accountDetailVM.OldPassword == null)
                {
                    ModelState.AddModelError("OldPassword", "Write your old password!");
                    return View(accountDetailVM);
                }

                if (accountDetailVM.Password != accountDetailVM.ConfirmPassword)
                {
                    ModelState.AddModelError("ConfirmPassword", "The password confirmation does not match!");
                    return View(accountDetailVM);
                }

                var result = await _userManager.ChangePasswordAsync(user, accountDetailVM.OldPassword, accountDetailVM.Password);

                if (!result.Succeeded)
                {
                    foreach (var item in result.Errors)
                    {
                        ModelState.AddModelError("", item.Description);
                        return View();
                    }
                }

            }

            user.FisrtName = accountDetailVM.FirstName;
            user.LastName = accountDetailVM.LastName;
            user.UserName = accountDetailVM.UserName;
            user.Email = accountDetailVM.Email;
            user.Gender = accountDetailVM.Gender;
            user.BirthDay= accountDetailVM.BirthDay;

            if (accountDetailVM.ImageFile != null)
            {
                if (accountDetailVM.ImageFile.ContentType != "image/jpeg" && accountDetailVM.ImageFile.ContentType != "image/png")
                {
                    ModelState.AddModelError("ImageFile", "Yalniz .jpg , .jpeg ve ya .png formatda fayl sece bilersiz!");
                    return View();
                }
                if (accountDetailVM.ImageFile.Length > 5242880)
                {
                    ModelState.AddModelError("ImageFile", "Maksimum uzunlugu 5Mb olan fayl sece bilersiz!");
                    return View();
                }

                string newFileName = FileManager.Save(_env.WebRootPath, "uploads/users", accountDetailVM.ImageFile);

                if (!string.IsNullOrWhiteSpace(user.Image))
                {
                    FileManager.Delete(_env.WebRootPath, "uploads/users", user.Image);
                }

                user.Image = newFileName;
            }
            else if (string.IsNullOrWhiteSpace(accountDetailVM.Image) && !string.IsNullOrWhiteSpace(user.Image))
            {

                FileManager.Delete(_env.WebRootPath, "uploads/users", user.Image);

                user.Image = null;
            }

            try
            {

                await _userManager.UpdateAsync(user);

            }
            catch (Exception)
            {

                FileManager.Delete(_env.WebRootPath, "uploads/users", accountDetailVM.Image);
            }

            return View();
        }

        public async Task<IActionResult> Address()
        {
            ViewBag.Setting = _context.Settings.FirstOrDefault();

            AppUser user = await _userManager.FindByNameAsync(User.Identity.Name);

            return View();
        }

        public IActionResult Register()
        {
            ViewBag.Setting = _context.Settings.FirstOrDefault();
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Register(UserRegisterVM userRegisterVM)
        {
            ViewBag.Setting = _context.Settings.FirstOrDefault();
            if (!ModelState.IsValid) return View();

            if (_userManager.Users.Any(x => x.NormalizedUserName == userRegisterVM.UserName.ToUpper()))
            {
                ModelState.AddModelError("UserName", "This username is using!");
                return View();
            }

            if (_userManager.Users.Any(x => x.NormalizedEmail == userRegisterVM.Email.ToUpper()))
            {
                ModelState.AddModelError("Email", "This email is using!");
                return View();
            }

            AppUser appUser = new AppUser
            {
                UserName = userRegisterVM.UserName,
                Email = userRegisterVM.Email,
                FisrtName = userRegisterVM.FirstName,
                LastName = userRegisterVM.LastName
            };

            var result = await _userManager.CreateAsync(appUser, userRegisterVM.Password);

            if (!result.Succeeded)
            {
                foreach (var item in result.Errors)
                {
                    ModelState.AddModelError("", item.Description);
                }
            }

            var rolResult = await _userManager.AddToRoleAsync(appUser, "Member");

            if (!rolResult.Succeeded)
            {
                foreach (var item in rolResult.Errors)
                {
                    ModelState.AddModelError("", item.Description);
                }
            }

            await _signInManager.SignInAsync(appUser, true);

            if (userRegisterVM.ImageFile != null)
            {
                if (userRegisterVM.ImageFile.ContentType != "image/jpeg" && userRegisterVM.ImageFile.ContentType != "image/png")
                {
                    ModelState.AddModelError("ImageFile", "You can choose file only .jpg, .jpeg or .png format!");
                    return View();
                }

                if (userRegisterVM.ImageFile.Length > 5242880)
                {
                    ModelState.AddModelError("ImageFile", "You can choose file only maximum 5Mb !");
                    return View();
                }

                appUser.Image = FileManager.Save(_env.WebRootPath, "uploads/users", userRegisterVM.ImageFile);
            }

            try
            {
                _context.SaveChanges();
            }
            catch (Exception)
            {

                FileManager.Delete(_env.WebRootPath, "uploads/users", userRegisterVM.Image);
            }


            return RedirectToAction("index", "home");
        }

        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Login(UserLoginVM userLoginVM)
        {
            AppUser user = await _userManager.FindByNameAsync(userLoginVM.UserName);

            if (user == null || user.IsAdmin)
            {
                ModelState.AddModelError("", "Username or Password is false!");
                return View();
            }

            var result = await _signInManager.PasswordSignInAsync(user, userLoginVM.Password, true, false);

            if (!result.Succeeded)
            {
                ModelState.AddModelError("", "Username or Password is false!");
                return View();
            }

            return RedirectToAction("index", "home");
        }

        public async Task<IActionResult> Logout()
        {
            await _signInManager.SignOutAsync();

            return RedirectToAction("login");
        }

        //public IActionResult ForgotPassword()
        //{
        //    return View();
        //}

        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public async Task<IActionResult> ForgotPassword(ForgotPasswordVM forgotPasswordVM)
        //{
        //    AppUser user = await _userManager.FindByEmailAsync(forgotPasswordVM.Email);

        //    if (user == null)
        //    {
        //        ModelState.AddModelError("Email", "Email is not valid!");
        //        return View();
        //    }

        //    string token = await _userManager.GeneratePasswordResetTokenAsync(user);
        //    string callback = Url.Action("resetpassword", "account", new { token, email = user.Email }, Request.Scheme);

        //    string body = string.Empty;

        //    using (StreamReader reader = new StreamReader("wwwroot/templates/forgot-password.html"))
        //    {
        //        body = reader.ReadToEnd();
        //    }
        //    body = body.Replace("{{url}}", callback);

        //    _emailService.Send(user.Email, "Reset Password!", body);

        //    return RedirectToAction("login");
        //}

        //public IActionResult ResetPassword(string token, string email)
        //{
        //    ResetPasswordVM resetPasswordVM = new ResetPasswordVM
        //    {
        //        Token = token,
        //        Email = email
        //    };
        //    return View(resetPasswordVM);
        //}

        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public async Task<IActionResult> ResetPassword(ResetPasswordVM resetPasswordVM)
        //{
        //    if (!ModelState.IsValid) return View(resetPasswordVM);

        //    AppUser user = await _userManager.FindByEmailAsync(resetPasswordVM.Email);

        //    if (user == null) return View("NotFound");

        //    var resetResult = await _userManager.ResetPasswordAsync(user, resetPasswordVM.Token, resetPasswordVM.Password);

        //    if (!resetResult.Succeeded)
        //    {
        //        foreach (var item in resetResult.Errors)
        //        {
        //            ModelState.AddModelError("", item.Description);
        //        }
        //        return View(resetPasswordVM);
        //    }

        //    return RedirectToAction("login");
        //}

        //public IActionResult Cart()
        //{
        //    return View();
        //}

        //public IActionResult Wishlist()
        //{
        //    return View();
        //}

        //public IActionResult Checkout()
        //{
        //    return View();
        //}
    }
}
