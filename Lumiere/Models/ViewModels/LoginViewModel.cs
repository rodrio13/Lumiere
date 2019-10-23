using System.ComponentModel.DataAnnotations;

namespace Lumiere.Models.ViewModels
{
    public class LoginViewModel
    {
        [DataType(DataType.EmailAddress)]
        [Required(ErrorMessage = "Enter your email"), StringLength(30)]
        public string Email { get; set; }
        [DataType(DataType.Password)]
        [Required(ErrorMessage = "Enter your password"), StringLength(30)]
        public string Password { get; set; }
    }
}
