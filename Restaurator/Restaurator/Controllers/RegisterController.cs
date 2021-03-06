﻿using System;
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
                        Token = Guid.NewGuid().ToString()
                    };

                    _context.Users.Add(user);
                    _context.SaveChanges();


                    Response.Cookies.Append("token", user.Token, new Microsoft.AspNetCore.Http.CookieOptions
                    {
                        Expires = DateTime.Now.AddDays(5),
                        HttpOnly = true
                    });

                    return RedirectToAction("index", "Places");
                }

                ModelState.AddModelError("Email", "This Email is already registered");
            }

            return View("~/Views/Places/Index.cshtml");
        }

    }
}