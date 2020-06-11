using System.ComponentModel.DataAnnotations;

namespace Partials.Models {
    public class LogUser {
        [Required]
        [EmailAddress]
        public string EmailLogin {get; set;}
        [Required]
        [MinLength(6)]
        public string PasswordLogin {get; set;}
    }
}