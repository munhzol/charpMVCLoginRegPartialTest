using System.ComponentModel.DataAnnotations;

namespace Partials.Models {
    public class RegUser {
        [Required]
        [MinLength(3)]
        public string FirstName {get; set;}
        [Required]
        [MinLength(3)]
        public string LastName {get; set;}
        [Required]
        [EmailAddress]
        public string Email {get; set;}
        [Required]
        [MinLength(6)]
        public string Password {get; set;}
        [Required]
        [Compare("Password")]
        public string PasswordCnfrm {get; set;}

    }
}