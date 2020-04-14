using System.ComponentModel.DataAnnotations;

namespace Restaurator.ViewModels
{
    public class RegisterViewModel
    {

        [Required(ErrorMessage = "This field is required.")]
        [MaxLength(50, ErrorMessage = "Maximum number of characters is 50.")]
        public string Fullname { get; set; }

        [Required(ErrorMessage = "This field is required.")]
        [MaxLength(50, ErrorMessage = "Maximum number of characters is 50.")]
        [EmailAddress(ErrorMessage = "Enter correct E-mail address.")]
        public string Email { get; set; }

        [Required(ErrorMessage = "This field is required.")]
        [MaxLength(50, ErrorMessage = "Maximum number of characters is 50.")]
        [MinLength(6, ErrorMessage = "Minimum number of characters is 6.")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
    }
}
