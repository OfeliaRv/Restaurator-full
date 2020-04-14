using System;
using System.ComponentModel.DataAnnotations;

namespace Restaurator.Models
{
    public class Reservation
    {
        public int Id { get; set; }

        public int PlaceId { get; set; }
       
        [Required]
        [MaxLength(100)]
        public string Fullname { get; set; }

        [Required]
        [MaxLength(30)]
        public string Phone { get; set; }

        [Required]
        [DataType(DataType.Date)]
        public DateTime Date { get; set; }

        [Required]
        [DataType(DataType.Time)]
        public DateTime Time { get; set; }

        [Required]
        [Range(1, 40, ErrorMessage = "Minimum number is 1 and maximum is 40")]
        public int numOfPersons { get; set; }

        public Place Place { get; set; }

    }
}
