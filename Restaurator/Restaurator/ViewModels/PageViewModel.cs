using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Restaurator.Models;

namespace Restaurator.ViewModels
{
    public class PageViewModel
    {
        public Place Place { get; set; }

        public List<PlaceInCirclePhoto> PlaceInCirclePhotos { get; set; }

        public Reservation Reservation { get; set; }

        public List<Comment> Comments { get; set; }

        public List<PlaceMenuItem> PlaceMenuItems { get; set; }

        public List<PlacePhoto> PlacePhotos { get; set; }
    }

   

    //public class ReservationViewModel
    //{
    //    public int PlaceId { get; set; }

    //    [Required(ErrorMessage = "This field is required.")]
    //    [MaxLength(50, ErrorMessage = "Maximum number of characters is 50.")]
    //    public string Fullname { get; set; }

    //    [Required(ErrorMessage = "This field is required.")]
    //    [MaxLength(25, ErrorMessage = "Maximum number of characters is 25.")]
    //    public string Phone { get; set; }

    //    [Required(ErrorMessage = "This field is required.")]
    //    public int numOfPersons { get; set; }

    //    [Required(ErrorMessage = "This field is required.")]
    //    public DateTime Date { get; set; }

    //    [Required(ErrorMessage = "This field is required.")]
    //    public DateTime Time { get; set; }
    //}
}
