namespace Restaurator.Models
{
    public class PlaceMenuItem
    {
        public int Id { get; set; }
        
        public int PlaceId { get; set; }
       
        public string ItemName { get; set; }
       
        public string ItemDescription { get; set; }
        
        public decimal ItemPrice { get; set; }
        
        public Place Place { get; set; }
    }
}
