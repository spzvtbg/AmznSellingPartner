namespace AmznSellingPartner.Clients.Attributes
{
    using System;
    using System.Collections;
    using System.ComponentModel.DataAnnotations;

    [AttributeUsage(AttributeTargets.All, AllowMultiple = false, Inherited = true)]
    public class ItemsMinLengthAttribute : AmznValidationAttribute
    {
        private readonly int length;

        public ItemsMinLengthAttribute(int length)
        {
            this.length = length;
            this.ErrorMessage = $"{{0}} is invalid. The minimum alowed length is {this.length}.";
        }

        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            var validationResult = base.IsValid(value, validationContext);

            if (value is IEnumerable enumerable)
            {
                foreach (var item in enumerable)
                {
                    if ($"{item}".Length < this.length)
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
