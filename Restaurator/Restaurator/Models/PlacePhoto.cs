namespace Restaurator.Models
{
    public class PlacePhoto
    {
        public int Id { get; set; }

        public int PlaceId { get; set; }

        public string Photo { get; set; }

        public string Text { get; set; }

        public Place Place { get; set; }
    }
}
