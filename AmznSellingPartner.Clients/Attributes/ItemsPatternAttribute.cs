namespace AmznSellingPartner.Clients.Attributes
{
    using System;
    using System.Collections;
    using System.ComponentModel.DataAnnotations;
    using System.Text.RegularExpressions;

    [AttributeUsage(AttributeTargets.All, AllowMultiple = false, Inherited = true)]
    public class ItemsPatternAttribute : AmznValidationAttribute
    {
        private readonly string pattern;

        public ItemsPatternAttribute(string pattern)
        {
            this.pattern = pattern;
            this.ErrorMessage = $"Value {{0}} dose not match - '{this.pattern}'.";
        }

        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            var validationResult = base.IsValid(value, validationContext);

            if (value is IEnumerable enumerable)
            {
                foreach (var item in enumerable)
                {
                    if (!Regex.IsMatch($"{item}", this.pattern))
                    {
                        validationResult = this.Failed(value, validationContext);

                        break;
                    }
                }
            }

            return validationResult;
        }
    }
}
