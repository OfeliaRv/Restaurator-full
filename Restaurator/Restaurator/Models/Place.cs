using System.Collections.Generic;

namespace Restaurator.Models
{
    public class Place
    {
        public int Id { get; set; }

        public string NamePt1 { get; set; }

        public string NamePt2 { get; set; }

        public string Description { get; set; }

        public string MainImage { get; set; }

        public string TopSectionImage { get; set; }

        public string PlaceType { get; set; }

        public string InstaLink { get; set; }

        public string FbLink { get; set; }

        public List<Reservation> Reservations { get; set; }

        public List<PlacePhoto> PlacePhotos { get; set; }

        public List<PlaceInCirclePhoto> PlaceInCirclePhotos { get; set; }

        public List<PlaceMenuItem> PlaceMenuItems { get; set; }

        public List<Comment> Comments { get; set; }
       
        public decimal Rating { get; set; }
    }
}
