using System.ComponentModel.DataAnnotations;
using SpgEstagioTeste.Models.Entities.Users;
using SpgEstagioTeste.Models.Enums;

namespace SpgEstagioTeste.Models.DTOS
{
    public class UserCreateDTO
    {
        [Required]
        public string Name { get; set; }

        [Required]
        public Role Role { get; set; }

        [Required, MinLength(5, ErrorMessage = "O número minimo de caracteres é 5")]
        public string Password { get; set; }

        [Required(ErrorMessage = "The email address is required")]
        [EmailAddress(ErrorMessage = "Invalid Email Address")]
        public string Email { get; set; }

        public User Map() => new User
        {
            Name = Name,
            Role = Role,
            Password = Password,
            Email = Email
        };
    }
}
