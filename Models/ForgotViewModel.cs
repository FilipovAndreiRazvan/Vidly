using System.ComponentModel.DataAnnotations;

namespace Vidly.Models.Account
{
    public class ForgotViewModel
    {
        [Required]
        [Display(Name = "Email")]
        public string Email { get; set; }
    }
}