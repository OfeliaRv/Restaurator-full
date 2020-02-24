using System;
using System.ComponentModel.DataAnnotations;

namespace Restaurator.Models
{
    public class Reservation
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(100)]
        public string Fullname { get; set; }

        [Required]
        [MaxLength(30)]
        public string Phone { get; set; }

        [Required]
        public DateTime Date { get; set; }

        [Required]
        public DateTime Time { get; set; }

        [Required]
        public int NumOfSeats { get; set; }

    }
}
