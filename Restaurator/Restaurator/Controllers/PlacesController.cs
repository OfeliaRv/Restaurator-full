using System;
using System.Collections.Generic;
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
                Place = _context.Places.Include("PlaceInCirclePhotos")
                    .Include("PlacePhotos")
                    .Include("Comments")
                    .Include("Reservations")
                    .Include("PlaceMenuItems").FirstOrDefault(m => m.Id == id),

                Reservation = _context.Reservations.FirstOrDefault(m => m.Id == id),
                Comments = _context.Comments.OrderByDescending(c => c.CreatedAt).ToList()
            };

            if (place == null)
            {
                return NotFound();
            }

            return View(place);
        }

        public IActionResult AddComment(Comment commentModel)
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
        public IActionResult MakeReservation(Reservation reservationModel)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
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

            return Ok(new
            {
                message = "Reservation is submitted successfully!"
            });
        }

        //// GET: Places/Create
        //public IActionResult Create()
        //{
        //    return View();
        //}

        //// POST: Places/Create
        //// To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        //// more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public async Task<IActionResult> Create([Bind("Id,Name,Rating")] Place place)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        _context.Add(place);
        //        await _context.SaveChangesAsync();
        //        return RedirectToAction(nameof(Index));
        //    }
        //    return View(place);
        //}

        //// GET: Places/Edit/5
        //public async Task<IActionResult> Edit(int? id)
        //{
        //    if (id == null)
        //    {
        //        return NotFound();
        //    }

        //    var place = await _context.Places.FindAsync(id);
        //    if (place == null)
        //    {
        //        return NotFound();
        //    }
        //    return View(place);
        //}

        //// POST: Places/Edit/5
        //// To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        //// more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public async Task<IActionResult> Edit(int id, [Bind("Id,Name,Rating")] Place place)
        //{
        //    if (id != place.Id)
        //    {
        //        return NotFound();
        //    }

        //    if (ModelState.IsValid)
        //    {
        //        try
        //        {
        //            _context.Update(place);
        //            await _context.SaveChangesAsync();
        //        }
        //        catch (DbUpdateConcurrencyException)
        //        {
        //            if (!PlaceExists(place.Id))
        //            {
        //                return NotFound();
        //            }
        //            else
        //            {
        //                throw;
        //            }
        //        }
        //        return RedirectToAction(nameof(Index));
        //    }
        //    return View(place);
        //}

        //// GET: Places/Delete/5
        //public async Task<IActionResult> Delete(int? id)
        //{
        //    if (id == null)
        //    {
        //        return NotFound();
        //    }

        //    var place = await _context.Places
        //        .FirstOrDefaultAsync(m => m.Id == id);
        //    if (place == null)
        //    {
        //        return NotFound();
        //    }

        //    return View(place);
        //}

        //// POST: Places/Delete/5
        //[HttpPost, ActionName("Delete")]
        //[ValidateAntiForgeryToken]
        //public async Task<IActionResult> DeleteConfirmed(int id)
        //{
        //    var place = await _context.Places.FindAsync(id);
        //    _context.Places.Remove(place);
        //    await _context.SaveChangesAsync();
        //    return RedirectToAction(nameof(Index));
        //}

        //private bool PlaceExists(int id)
        //{
        //    return _context.Places.Any(e => e.Id == id);
        //}
    }
}
