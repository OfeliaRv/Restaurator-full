using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Restaurator.Models
{
    public class PlaceMenuItem
    {
        public int Id { get; set; }
        
        public int PlaceId { get; set; }

        [Required]
        public string ItemName { get; set; }
       
        public string ItemDescription { get; set; }

        [Required]
        public decimal ItemPrice { get; set; }
        
        public Place Place { get; set; }
    }
}
