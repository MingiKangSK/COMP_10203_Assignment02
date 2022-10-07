using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace COMP_10203_Assignment01.Models
{
    public class ApplicationUser:IdentityUser
    {
        [Required, Display(Name = "First Name")]
        public string FirstName { get; set; } = String.Empty;
        [Required, Display(Name = "Last Name")]
        public string LastName { get; set; }
/*        [Required]
        public string Username { get; set; }
        [Required]
        public string Email { get; set; }
        [Display(Name = "Phone Number")]
        public string PhoneNumber { get; set; }*/
        [Display(Name = "Birth Date")]
        [DataType(DataType.Date)]
        [MyDate(ErrorMessage = "Invalid date you cannot be born in the future")]
        public DateTime? BirthDate { get; set; }
    }
}
