using System;
using System.Linq;
using CryptoHelper;
using Microsoft.AspNetCore.Mvc;
using Restaurator.Data;
using Restaurator.Injection;
using Restaurator.Models;
using Restaurator.ViewModels;


namespace Restaurator.Controllers
{
    public class RegisterController : Controller
    {
        private readonly RestauratorDbContext _context;
        private readonly IAuth _auth;

        public RegisterController(RestauratorDbContext context, IAuth auth)
        {
            _context = context;
            _auth = auth;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Register(RegisterViewModel Register)
        {
            if (ModelState.IsValid)
            {
                if (!_context.Users.Any(u => u.Email == Register.Email))
                {
                    User user = new User
                    {
                        Email = Register.Email,
                        Fullname = Register.Fullname,
                        Password = Crypto.HashPassword(Register.Password),
                        repeatPassword = Register.repeatPassword,
                        Token = Guid.NewGuid().ToString()
                    };

                    if (user.repeatPassword == user.Password)
                    {
                        _context.Users.Add(user);
                        _context.SaveChanges();


                        Response.Cookies.Append("token", user.Token, new Microsoft.AspNetCore.Http.CookieOptions
                        {
                            Expires = DateTime.Now.AddYears(1),
                            HttpOnly = true
                        });

                        return RedirectToAction("index", "home");
                    }

                    else
                    {
                        ModelState.AddModelError("Password", "Passwords don't match");
                    }
                }

                ModelState.AddModelError("Email", "This Email is already registered");
            }

            return View("~/Views/Home/Index.cshtml");
        }

    }
}