namespace AmznSellingPartner.Clients.Attributes
{
    using System.ComponentModel.DataAnnotations;

    public class MaximumAttribute : AmznValidationAttribute
    {
        private readonly double maximum;

        public MaximumAttribute(double maximum)
        {
            this.maximum = maximum;
            this.ErrorMessage = $"{{0}} is invalid. The maximum alowed value is {this.maximum}.";
        }

        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            var validationResult = base.IsValid(value, validationContext);

            if (double.TryParse($"{value}", out var x) && x > this.maximum)
            {
                validationResult = this.Failed(value, validationContext);
            }

            return validationResult;
        }
    }
}
