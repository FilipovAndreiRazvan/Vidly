using System.ComponentModel.DataAnnotations;

namespace Vidly.Models.Account
{
    public class ExternalLoginConfirmationViewModel
    {
        [Required]
        [MaxLength(50)]
        public string Phone { get; set; }
        [Required]
        [Display(Name = "Email")]
        public string Email { get; set; }

        [Required]
        [Display(Name = "Driving License")]
        public string DrivingLicense { get; set; }
    }
}