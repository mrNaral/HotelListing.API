using System.ComponentModel.DataAnnotations;

namespace HotelListing.API.Core.Models.User
{
    public class LoginDto
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        [StringLength(15, ErrorMessage = "Your password must have at least {2} and a maximum of {1}.", MinimumLength = 6)]
        public string Password { get; set; }
    }
}