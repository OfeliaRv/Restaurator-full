using System.Collections.Generic;
using Restaurator.Models;

namespace Restaurator.ViewModels
{
    public class PageViewModel
    {
        public Place Place { get; set; }

        public List<PlaceInCirclePhoto> PlaceInCirclePhotos { get; set; }

        public Reservation Reservation { get; set; }

        public Comment Comment { get; set; }

        public List<PlaceMenuItem> PlaceMenuItems { get; set; }

        public List<PlacePhoto> PlacePhotos { get; set; }
    }
}
