using System.ComponentModel.DataAnnotations;

namespace MoshGigHub3.ViewModels
{
    public class ForgotViewModel
    {
        [Required]
        [Display(Name = "Email")]
        public string Email { get; set; }
    }
}