using System.ComponentModel.DataAnnotations;

namespace WebProject.Models
{
    public class UserSignUpViewModel
    {
        [Required(ErrorMessage ="Please enter name and surname")]
        public string NameSurname { get; set; }

        [Required(ErrorMessage = "Please enter password")]
        public string Password { get; set; }

        [Required(ErrorMessage ="Please enter correct confirm password")]
        public string ConfirmPassword { get; set; }

        [Required(ErrorMessage ="Please enter mail")]
        public string Mail { get; set; }

        [Required(ErrorMessage ="Please enter username")]
        public string UserName { get; set; }
    }
}
