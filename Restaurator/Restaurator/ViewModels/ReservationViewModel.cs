using System;
using System.ComponentModel.DataAnnotations;

namespace Restaurator.ViewModels
{
    public class ReservationViewModel
    {
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
