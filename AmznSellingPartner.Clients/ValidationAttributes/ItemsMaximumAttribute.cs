namespace AmznSellingPartner.Clients.ValidationAttributes
{
    using System;
    using System.Collections;
    using System.ComponentModel.DataAnnotations;

    [AttributeUsage(AttributeTargets.All, AllowMultiple = false, Inherited = true)]
    public class ItemsMaximumAttribute : AmznValidationAttribute
    {
        private readonly double maximum;

        public ItemsMaximumAttribute(double maximum)
        {
            this.maximum = maximum;
            this.ErrorMessage = $"{{0}} is invalid. The maximum alowed value is {this.maximum}.";
        }

        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            var validationResult = base.IsValid(value, validationContext);

            if (value is IEnumerable enumerable)
            {
                foreach (var item in enumerable)
                {
                    if (double.TryParse($"{item}", out var x) && x > this.maximum)
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
