using CryptoHelper;
using Microsoft.AspNetCore.Mvc;
using Restaurator.Data;
using Restaurator.Filters;
using Restaurator.Injection;
using Restaurator.Models;
using Restaurator.ViewModels;
using System;
using System.Linq;

namespace Restaurator.Controllers
{
    public class LoginController : Controller
    {
        private readonly RestauratorDbContext _context;
        private readonly IAuth _auth;

        public LoginController(RestauratorDbContext context, IAuth auth)
        {
            _context = context;
            _auth = auth;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login(LoginViewModel login)
        {
            if (ModelState.IsValid)
            {
                User user = _context.Users.FirstOrDefault(u => u.Email == login.Email);

                if (user != null)
                {
                    if (Crypto.VerifyHashedPassword(user.Password, login.Password))
                    {
                        user.Token = Guid.NewGuid().ToString();
                        _context.SaveChanges();

                        Response.Cookies.Append("token", user.Token, new Microsoft.AspNetCore.Http.CookieOptions
                        {
                            Expires = DateTime.Now.AddYears(1),
                            HttpOnly = true
                        });

                        return RedirectToAction("index", "home");
                    }
                }

                ModelState.AddModelError("Password", "Email or password is incorrect");
            }

            return View("~/Views/Login/index.cshtml");
        }

        [TypeFilter(typeof(CheckAuth))]
        public IActionResult Logout()
        {
            User user = _context.Users.Find(_auth.User.Id);
            user.Token = null;
            _context.SaveChanges();
            Response.Cookies.Delete("token");

            return RedirectToAction("index");
        }
    }
}