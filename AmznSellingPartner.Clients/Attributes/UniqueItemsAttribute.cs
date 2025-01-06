namespace AmznSellingPartner.Clients.Attributes
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    [AttributeUsage(AttributeTargets.All, AllowMultiple = false, Inherited = true)]
    public class UniqueItemsAttribute : AmznValidationAttribute
    {
        public UniqueItemsAttribute() => this.ErrorMessage = $"Collection dose not contains unique values.";

        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            var validationResult = base.IsValid(value, validationContext);

            if (value is IEnumerable enumerable)
            {
                var uniqueValues = new HashSet<object>();
                var itemsCount = 0;

                foreach (var item in enumerable)
                {
                    uniqueValues.Add(item);

                    itemsCount++;
                }

                if (itemsCount == uniqueValues.Count)
                {
                    validationResult = this.Failed(value, validationContext);
                }
            }

            return validationResult;
        }
    }
}
