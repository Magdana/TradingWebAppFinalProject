using System;
using System.ComponentModel.DataAnnotations;

public class MinimumAgeAttribute : ValidationAttribute
{
    private readonly int _minimumAge;

    public MinimumAgeAttribute(int minimumAge)
    {
        _minimumAge = minimumAge;
    }

    protected override ValidationResult IsValid(object value, ValidationContext validationContext)
    {
        // Add your age validation logic here...
        // Ensure that the age is greater than or equal to _minimumAge
        // Return ValidationResult.Success or a ValidationResult with an error message

        // Example logic:
        if (value is DateTime birthDate)
        {
            var today = DateTime.Today;
            var age = today.Year - birthDate.Year;

            if (birthDate.Date > today.AddYears(-age))
            {
                age--;
            }

            if (age >= _minimumAge)
            {
                return ValidationResult.Success;
            }
        }

        return new ValidationResult(ErrorMessage);
    }
}
