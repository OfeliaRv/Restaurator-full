using System;
using System.ComponentModel.DataAnnotations;

namespace Restaurator.ViewModels
{
    public class PageViewModel
    {
        public ReservationViewModel Reservation { get; set; }
        public CommentViewModel Comment { get; set; }
    }

    public class CommentViewModel
    {
        public int PlaceId { get; set; }

        public int UserId { get; set; }

        [Required(ErrorMessage = "This field is required.")]
        [MaxLength(500, ErrorMessage = "Maximum number of characters is 500.")]
        public string CommentText { get; set; }

        [Required(ErrorMessage = "This field is required.")]
        [Range(0, 5)]
        public decimal Rating { get; set; }

        [Required]
        public DateTime CreatedAt { get; set; }
    }

    public class ReservationViewModel
    {
        public int PlaceId { get; set; }

        [Required(ErrorMessage = "This field is required.")]
        [MaxLength(50, ErrorMessage = "Maximum number of characters is 50.")]
        public string Fullname { get; set; }

        [Required(ErrorMessage = "This field is required.")]
        [MaxLength(25, ErrorMessage = "Maximum number of characters is 25.")]
        public string Phone { get; set; }

        [Required(ErrorMessage = "This field is required.")]
        public int numOfPersons { get; set; }

        [Required(ErrorMessage = "This field is required.")]
        public DateTime Date { get; set; }

        [Required(ErrorMessage = "This field is required.")]
        public DateTime Time { get; set; }
    }
}
