
using System.ComponentModel.DataAnnotations;

namespace COMP_10203_Assignment01.Models
{
    internal class MyDateAttribute : ValidationAttribute
    {
        public override bool IsValid(object value)
        {
            DateTime date = Convert.ToDateTime(value);
            return date <= DateTime.Now;

        }
    }
}