using System.ComponentModel.DataAnnotations;

namespace COMP_10203_Assignment01.Models
{
    public class Team
    {
        [Key]
        public int Id { get; set; }
        [Required, Display(Name = "Team Name")]
        public string TeamName { get; set; }
        [Required]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        [DataType(DataType.Date)]
        [TeamDate(ErrorMessage = "Please select a valid date")]
        public DateTime? EstablishedDate { get; set; }
    }
}
