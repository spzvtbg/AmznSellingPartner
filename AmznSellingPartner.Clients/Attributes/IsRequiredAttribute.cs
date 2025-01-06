namespace AmznSellingPartner.Clients.Attributes
{
    using System;
    using System.ComponentModel.DataAnnotations;

    [AttributeUsage(AttributeTargets.All, AllowMultiple = false, Inherited = true)]
    public class IsRequiredAttribute : AmznValidationAttribute
    {
        public IsRequiredAttribute() => this.ErrorMessage = "{0} is required.";

        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            if (value is null)
            {
                return this.Failed(value, validationContext);
            }
            else
            {
                var type = value.GetType();

                if (type.IsValueType && !type.IsEnum && type != typeof(string))
                {
                    var _default = Activator.CreateInstance(type);

                    if (value.Equals(_default))
                    {
                        return this.Failed(value, validationContext);
                    }
                }
            }

            return base.IsValid(value, validationContext);
        }
    }
}
