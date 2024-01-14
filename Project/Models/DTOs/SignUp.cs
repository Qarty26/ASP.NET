using System.ComponentModel.DataAnnotations;

namespace Roads.Models.DTOs
{
    public class SignUp
    {
        [Required]
        public string UserName { get; set; }    
        [Required]
        public string Email { get; set; }
        [Required]
        public string Password { get; set; }
    }
}
