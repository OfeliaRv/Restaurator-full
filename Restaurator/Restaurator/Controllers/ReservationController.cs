using System;
using Microsoft.AspNetCore.Mvc;
using Restaurator.Data;
using Restaurator.Models;
using Restaurator.ViewModels;

namespace Restaurator.Controllers
{
    public class ReservationController : Controller
    {
        private readonly RestauratorDbContext _context;

        public ReservationController(RestauratorDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult MakeReservation(ReservationViewModel model)
        {
            Place place = new Place();
            if (ModelState.IsValid)
            {
                Reservation reservation = new Reservation
                {
                    Fullname = model.Fullname,
                    Phone = model.Phone,
                    numOfPersons = model.numOfPersons,
                    Date = model.Date,
                    Time = model.Time,
                    placeId = place.Id,
                };

                _context.Reservations.Add(reservation);
                _context.SaveChanges();

                return Ok(new
                {
                    message = "Resume is submitted successfully!"
                });

            }

            return BadRequest(ModelState);
        }
    }
}