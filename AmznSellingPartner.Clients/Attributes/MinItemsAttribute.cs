namespace AmznSellingPartner.Clients.Attributes
{
    using System;
    using System.Collections;
    using System.ComponentModel.DataAnnotations;

    [AttributeUsage(AttributeTargets.All, AllowMultiple = false, Inherited = true)]
    public class MinItemsAttribute : AmznValidationAttribute
    {
        private readonly int count;

        public MinItemsAttribute(int count)
        {
            this.count = count;
            this.ErrorMessage = $"{{0}} is invalid. The minimum alowed items count is {this.count}.";
        }

        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            var validationResult = base.IsValid(value, validationContext);

            if (value is IEnumerable enumerable)
            {
                foreach (var item in enumerable)
                {
                    if ($"{item}".Length < this.count)
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
