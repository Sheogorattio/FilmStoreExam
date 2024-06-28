using System.ComponentModel.DataAnnotations;

namespace FilmStoreExam.ViewModels
{
    public class RegisterViewModel
    {
        [Required]
        [Display(Name = "Email")]
        [DataType(DataType.EmailAddress, ErrorMessage = "Invalid email")]
        public string? Email { get; set; }

        [Required]
        [Display(Name = "Nickname")]
        public string? Name { get; set; }

        [Required]
        [Display(Name = "Birth date")]
        [DataType(DataType.Date, ErrorMessage = "Invalid date")]
        public DateOnly BirthDate { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string? Password { get; set; }

        [Required]
        [Compare("Password", ErrorMessage = "Passwords are not matching")]
        [DataType(DataType.Password)]
        [Display(Name = "Confirm password")]
        public string? PasswordConfirm { get; set; }
    }
}
