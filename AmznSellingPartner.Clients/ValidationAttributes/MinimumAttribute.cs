namespace AmznSellingPartner.Clients.ValidationAttributes
{
    using System.ComponentModel.DataAnnotations;

    public class MinimumAttribute : AmznValidationAttribute
    {
        private readonly double minimum;

        public MinimumAttribute(double minimum)
        {
            this.minimum = minimum;
            this.ErrorMessage = $"The maximum alowed value is {this.minimum}.";
        }

        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            var validationResult = base.IsValid(value, validationContext);

            if (double.TryParse($"{value}", out var x) && x < this.minimum)
            {
                validationResult = this.Failed(value, validationContext);
            }

            return validationResult;
        }
    }
}
