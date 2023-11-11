using System.ComponentModel.DataAnnotations;

namespace Tranning.Validations
{
    public class AllowedSizeFile : ValidationAttribute
    {
        private readonly int _maxSizeFile;
        public AllowedSizeFile(int maxSizeFile)
        {
            _maxSizeFile = maxSizeFile;
        }

        protected override ValidationResult? IsValid(
            object value, ValidationContext validationContext
        ) {
            var file = value as IFormFile;
            if ( file != null )
            {
                if (file.Length > _maxSizeFile)
                {
                    return new ValidationResult(GetMessgeError());
                }
            }
            return ValidationResult.Success;
        }
        private string GetMessgeError()
        {
            return $"Maximum a allowed file size is {_maxSizeFile} bytes.";
        }
    }
}
