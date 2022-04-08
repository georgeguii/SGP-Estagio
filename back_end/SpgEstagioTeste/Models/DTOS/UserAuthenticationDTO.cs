using System.ComponentModel.DataAnnotations;

namespace SpgEstagioTeste.Models.DTOS
{
    public class UserAuthenticationDTO
    {


        [Required, MinLength(5, ErrorMessage = "O número minimo de caracteres é 5")]
        public string Password { get; set; }

        [Required(ErrorMessage = "The email address is required")]
        [EmailAddress(ErrorMessage = "Invalid Email Address")]
        public string Email { get; set; }

    }
}
