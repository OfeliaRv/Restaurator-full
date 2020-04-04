namespace Restaurator.Models
{
    public class PlaceInCirclePhoto
    {
        public int Id { get; set; }

        public int PlaceId { get; set; }

        public string PhotoInCircle { get; set; }

        public string CircleText { get; set; }
        
        public string CircleTextHeading1 { get; set; }

        public string CircleTextHeading2 { get; set; }

        public Place Place { get; set; }
    }
}
