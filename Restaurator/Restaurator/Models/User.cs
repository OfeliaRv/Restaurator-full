﻿using System.ComponentModel.DataAnnotations;

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
        
        [Required]
        [MaxLength(150)]
        [Compare("Password")]
        [DataType(DataType.Password)]
        public string repeatPassword { get; set; }

        [MaxLength(100)]
        public string Token { get; set; }
    }
}
