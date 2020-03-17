using System.ComponentModel.DataAnnotations;

namespace Restaurator.Models
{
    public class Comment
    {
        public int Id { get; set; }
        
        [Required]
        [MaxLength(5)]
        public decimal Rating { get; set; }

        [Required]
        [MaxLength(500)]
        public int CommentText { get; set; }

        public Place Place { get; set; }

        public int UserId { get; set; }
    }
}
