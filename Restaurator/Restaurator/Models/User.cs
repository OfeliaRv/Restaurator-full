using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

namespace Restaurator.Models
{
    public class User
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(50)]
        public string Fullname { get; set; }

        [Required]
        [MaxLength(50)]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        [MaxLength(150)]
        [DataType(DataType.Password)]
        public string Password { get; set; }
        
        public List<Comment> Comments { get; set; }

        [MaxLength(100)]
        public string Token { get; set; }
    }
}
