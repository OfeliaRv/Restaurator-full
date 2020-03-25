using System;
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
        public string CommentText { get; set; }
       
        public int PlaceId { get; set; }
        
        public int UserId { get; set; }

        [Required]
        public DateTime CreatedAt { get; set; }

        public User User { get; set; }

        public Place Place { get; set; }
    }
}
