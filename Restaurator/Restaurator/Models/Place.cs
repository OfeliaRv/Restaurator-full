using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Restaurator.Models
{
    public class Place
    {
        public int Id { get; set; }

        [Required]
        public string NamePt1 { get; set; }

        public string NamePt2 { get; set; }

        [Required]
        public string Description { get; set; }

        [Required]
        public string MainImage { get; set; }

        [Required]
        public string TopSectionImage { get; set; }

        [Required]
        public string PlaceType { get; set; }

        [Required]
        public string Type1 { get; set; }

        public string Type2 { get; set; }

        public string InstaLink { get; set; }

        public string FbLink { get; set; }

        [Required]
        public string OpenHours { get; set; }

        [Required]
        public string Address { get; set; }

        [Required]
        public string PlacePhone { get; set; }

        [Required]
        public string PlaceMap { get; set; }

        [Required]
        public int Rating { get; set; }

        public List<Reservation> Reservations { get; set; }

        public List<PlacePhoto> PlacePhotos { get; set; }

        public List<PlaceInCirclePhoto> PlaceInCirclePhotos { get; set; }

        public List<PlaceMenuItem> PlaceMenuItems { get; set; }

        public List<Comment> Comments { get; set; }
      
    }
}
