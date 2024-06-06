using System.ComponentModel.DataAnnotations;

namespace Lab_2_final.Attributes
{
    public class IndexAttribute : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            if (value != null)
            {
                string index = value.ToString();

                if (index.Length != 6)
                {
                    return new ValidationResult("Индекс должен состоять из шести цифр.");
                }

                if (!IsDigitsOnly(index))
                {
                    return new ValidationResult("Индекс должен содержать только цифры.");
                }
            }

            return ValidationResult.Success;
        }

        private bool IsDigitsOnly(string value)
        {
            foreach (char c in value)
            {
                if (c < '0' || c > '9')
                    return false;
            }

            return true;
        }
    }
}
