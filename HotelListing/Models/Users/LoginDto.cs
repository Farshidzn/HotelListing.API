using System.ComponentModel.DataAnnotations;

namespace HotelListing.Models.Users
{
    public class LoginDto
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; }
        public String Password { get; set; }
    }
}
