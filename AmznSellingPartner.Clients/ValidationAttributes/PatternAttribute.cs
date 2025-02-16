namespace AmznSellingPartner.Clients.ValidationAttributes
{
    using System;
    using System.ComponentModel.DataAnnotations;
    using System.Text.RegularExpressions;

    [AttributeUsage(AttributeTargets.All, AllowMultiple = false, Inherited = true)]
    public class PatternAttribute : AmznValidationAttribute
    {
        private readonly string pattern;

        public PatternAttribute(string pattern)
        {
            this.pattern = pattern;
            this.ErrorMessage = $"Value {{0}} dose not match - '{this.pattern}'.";
        }

        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            var validationResult = base.IsValid(value, validationContext);

            if (!Regex.IsMatch($"{value}", this.pattern))
            {
                validationResult = this.Failed(value, validationContext);
            }

            return validationResult;
        }
    }
}
