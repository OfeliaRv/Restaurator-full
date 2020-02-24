using System.ComponentModel.DataAnnotations;

namespace Restaurator.Models
{
    public class Comment
    {

        [Required]
        [MaxLength(5)]
        public double Rating { get; set; }

        [Required]
        [MaxLength(500)]
        public int CommentText { get; set; }
      
        public User Username { get; set; }
    }
}
