using System.ComponentModel.DataAnnotations;

namespace Lumiere.Models.ViewModels
{
    public class RegisterViewModel
    {
        [Required(ErrorMessage = "Enter your first name"), StringLength(30)]
        [Display(Name = "First Name")]
        public string FirstName { get; set; }
        [Required(ErrorMessage = "Enter your last name"), StringLength(30)]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }
        [Display(Name = "Username")]
        public string UserName { get; set; }
        [DataType(DataType.EmailAddress)]
        [Required(ErrorMessage = "Enter your email"), StringLength(30)]
        public string Email { get; set; }
        [DataType(DataType.Password)]
        [Required(ErrorMessage = "Enter your password"), StringLength(30)]
        public string Password { get; set; }
        [DataType(DataType.Password)]
        [Compare("Password", ErrorMessage = "Password does not match"), StringLength(30)]
        [Display(Name = "Re-enter password")]
        public string ReEnterPassword { get; set; }
    }
}