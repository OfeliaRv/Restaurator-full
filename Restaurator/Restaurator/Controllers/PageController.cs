using Microsoft.AspNetCore.Mvc;
using Restaurator.Data;
using Restaurator.Injection;
using Restaurator.Models;
using Restaurator.ViewModels;
using System;

namespace Restaurator.Controllers
{
    public class PageController : Controller
    {
        private readonly RestauratorDbContext _context;
        private readonly IAuth _auth;

        public PageController(RestauratorDbContext context, IAuth auth)
        {
            _context = context;
            _auth = auth;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddComment(CommentViewModel commentModel)
        {
            if (ModelState.IsValid)
            {
                Comment comment = new Comment
                {
                    PlaceId = commentModel.PlaceId,
                    UserId = _auth.User.Id,
                    CommentText = commentModel.CommentText,
                    Rating = commentModel.Rating,
                    CreatedAt = DateTime.Now
                };

                _context.Comments.Add(comment);
                _context.SaveChanges();

                return Ok(new
                {
                    message = "Comment is submitted successfully!"
                });

            }

            return BadRequest(ModelState);
        }

        [HttpPost]
        public IActionResult MakeReservation(ReservationViewModel reservationModel)
        {
            if (ModelState.IsValid)
            {
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

                return Ok(new
                {
                    message = "Reservation is submitted successfully!"
                });

            }

            return BadRequest(ModelState);
        }
    }
}