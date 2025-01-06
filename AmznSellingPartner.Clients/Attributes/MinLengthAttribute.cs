namespace AmznSellingPartner.Clients.Attributes
{
    using System;
    using System.ComponentModel.DataAnnotations;

    [AttributeUsage(AttributeTargets.All, AllowMultiple = false, Inherited = true)]
    public class MinLengthAttribute : AmznValidationAttribute
    {
        private readonly int length;

        public MinLengthAttribute(int length)
        {
            this.length = length;
            this.ErrorMessage = $"{{0}} is invalid. The minimum alowed length is {this.length}.";
        }

        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            var validationResult = base.IsValid(value, validationContext);

            if ($"{value}".Length < this.length)
            {
                validationResult = this.Failed(value, validationContext);
            }

            return validationResult;
        }
    }
}
