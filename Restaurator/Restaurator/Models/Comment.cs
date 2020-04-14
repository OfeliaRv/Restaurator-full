using System;
using System.ComponentModel.DataAnnotations;

namespace Restaurator.Models
{
    public class Comment
    {
        [Key]
        public int Id { get; set; }
        
        [Required]
        [Range(0,5)]
        public int Rating { get; set; }

        public string Username { get; set; }

        [Required]
        [MaxLength(500, ErrorMessage = "Maximum number of characters is 500.")]
        public string CommentText { get; set; }
       
        public int PlaceId { get; set; }
        
        public int UserId { get; set; }

        [Required]
        public DateTime CreatedAt { get; set; }

        public User User { get; set; }

        public Place Place { get; set; }
    }
}
