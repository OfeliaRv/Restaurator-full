﻿using System;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Restaurator.Data;
using Restaurator.Injection;
using Restaurator.Models;
using Restaurator.ViewModels;

namespace Restaurator.Controllers
{
    public class PlacesController : Controller
    {
        private readonly RestauratorDbContext _context;
        private readonly IAuth _auth;

        public PlacesController(RestauratorDbContext context, IAuth auth)
        {
            _context = context;
            _auth = auth;
        }

        // GET: Places
        public async Task<IActionResult> Index()
        {
            return View(await _context.Places.ToListAsync());
        }

        // GET: Places/Details/{id}
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var place = new PageViewModel
            {
                Place = await _context.Places.Include("PlaceInCirclePhotos")
                    .Include("PlacePhotos")
                    .Include("Comments")
                    .Include("Reservations")
                    .Include("PlaceMenuItems").FirstOrDefaultAsync(m => m.Id == id),

                Reservation = _context.Reservations.FirstOrDefault(m => m.Id == id)
            };

            if (place == null)
            {
                return NotFound();
            }

            return View(place);
        }

        public async Task<IActionResult> AddComment(Comment commentModel)
        {
            if (ModelState.IsValid)
            {
                Comment comment = new Comment
                {
                    PlaceId = commentModel.PlaceId,
                    UserId = _auth.User.Id,
                    Username = _auth.User.Fullname,
                    CommentText = commentModel.CommentText,
                    Rating = commentModel.Rating,
                    CreatedAt = DateTime.Now
                };

                await _context.Comments.AddAsync(comment);
                await _context.SaveChangesAsync();

                return Ok(new
                {
                    message = "Comment is submitted successfully!"
                });

            }

            return BadRequest(ModelState);
        }

        [HttpPost]
        public IActionResult MakeReservation(Reservation reservationModel)
        {
            if (!ModelState.IsValid)
            {
                ModelState.AddModelError("Date", "Choose the date");
                ModelState.AddModelError("Time", "Choose the time");

                return RedirectToAction("details", "Places", new { id = reservationModel.PlaceId });
            }

            Reservation reservation = new Reservation
            {
                PlaceId = reservationModel.PlaceId,
                Fullname = reservationModel.Fullname,
                Phone = reservationModel.Phone,
                numOfPersons = reservationModel.numOfPersons,
                Date = reservationModel.Date,
                Time = reservationModel.Time
            };

            _context.Reservations.Add(reservation);
            _context.SaveChanges();

            if(reservation == null)
            {
                ModelState.AddModelError("Date", "Choose the date");
                ModelState.AddModelError("Time", "Choose the time");
            }

            return RedirectToAction("Success", "Places");
        }

        public IActionResult Success()
        {
            return View();
        }
    }
}
