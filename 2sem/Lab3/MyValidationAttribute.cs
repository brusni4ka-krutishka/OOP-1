using System.ComponentModel.DataAnnotations;

namespace Lab2
{
    public class NormalMetersAttribute : ValidationAttribute
    {
        public override bool IsValid(object value)
        {
            return (value is uint NormalMeters) && NormalMeters > 0;
        }
    }
}
