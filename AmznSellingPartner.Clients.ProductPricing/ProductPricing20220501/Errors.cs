namespace AmznSellingPartner.Clients.ProductPricing.ProductPricing20220501
{
    using AmznSellingPartner.Clients.ValidationAttributes;

    using Newtonsoft.Json;

    /// <summary>
    /// A list of error responses returned when a request is unsuccessful.
    /// </summary>
    public class Errors : BaseClass
    {
        /// <summary>
        /// One or more unexpected errors occurred during the operation.
        /// </summary>
        [JsonProperty("errors")]
        [IsRequired]
        public ErrorList ErrorsValue { get; set; }
    }
}
