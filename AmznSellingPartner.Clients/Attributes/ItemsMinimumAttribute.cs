namespace AmznSellingPartner.Clients.Attributes
{
    using System;
    using System.Collections;
    using System.ComponentModel.DataAnnotations;

    [AttributeUsage(AttributeTargets.All, AllowMultiple = false, Inherited = true)]
    public class ItemsMinimumAttribute : AmznValidationAttribute
    {
        private readonly double minimum;

        public ItemsMinimumAttribute(double minimum)
        {
            this.minimum = minimum;
            this.ErrorMessage = $"{{0}} is invalid. The minimum alowed value is {this.minimum}.";
        }

        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            var validationResult = base.IsValid(value, validationContext);

            if (value is IEnumerable enumerable)
            {
                foreach (var item in enumerable)
                {
                    if (double.TryParse($"{item}", out var x) && x < this.minimum)
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
