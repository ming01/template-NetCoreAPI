using Microsoft.AspNetCore.Http;
using System;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace NetCoreAPI.Validations
{
    public class ContentTypeValidator : ValidationAttribute
    {
        private readonly string[] _validContentTypes;
        private readonly string[] _imageContentTypes = new string[] { "image/jpeg", "image/jpg", "image/png", "image/gif" };

        public ContentTypeValidator(string[] ValidContentTypes)
        {
            _validContentTypes = ValidContentTypes;
        }

        public ContentTypeValidator(ContentTypeGroup contentTypeGroup)
        {
            switch (contentTypeGroup)
            {
                case ContentTypeGroup.Image:
                    _validContentTypes = _imageContentTypes;
                    break;
            }
        }

        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            if (value == null)
            {
                return ValidationResult.Success;
            }

            IFormFile formFile = value as IFormFile;

            if (formFile == null)
            {
                return ValidationResult.Success;
            }

            if (!_validContentTypes.Contains(formFile.ContentType))
            {
                return new ValidationResult($"Content-Type should be one of the following: {string.Join(",", _validContentTypes)}");
            }

            return ValidationResult.Success;
        }

        public enum ContentTypeGroup
        {
            Image
        }
    }
}