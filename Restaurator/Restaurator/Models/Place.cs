using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Restaurator.Models
{
    public class Place
    {
        public int Id { get; set; }

        [MaxLength(50)]
        public string Name { get; set; }
        
        public List<Reservation> Reservations { get; set; }

        //public List<PlaceImage> PlaceImages { get; set; }

        public List<Comment> Comments { get; set; }
        public decimal Rating { get; set; }
    }
}
