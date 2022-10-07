
using System.ComponentModel.DataAnnotations;

namespace COMP_10203_Assignment01.Models
{
    internal class TeamDateAttribute : ValidationAttribute
    {
        public override bool IsValid(object value)
        {
            if (value == null)
            {
                return true;
            }
            DateTime date = Convert.ToDateTime(value);
            return date >= DateTime.Now;
        }
    }
}