namespace AmznSellingPartner.Clients.ValidationAttributes
{
    using System;
    using System.ComponentModel.DataAnnotations;

    [AttributeUsage(AttributeTargets.All, AllowMultiple = false, Inherited = true)]
    public class AmznValidationAttribute : ValidationAttribute
    {
        protected ValidationResult Failed(object value, ValidationContext validationContext)
               => new ValidationResult(
                    errorMessage: this.FormatErrorMessage($"'{value}'"),
                    memberNames: [validationContext.DisplayName, validationContext.MemberName]);

        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
            => ValidationResult.Success;
    }
}
