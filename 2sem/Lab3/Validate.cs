using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Lab2
{
    public static class MyValidate
    {
        public static bool IsValid(object obj)
        {
            var results = new List<ValidationResult>();
            var context = new ValidationContext(obj);
            return (Validator.TryValidateObject(obj, context, results, true));
               
        }
    }
}
