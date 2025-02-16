namespace AmznSellingPartner.Clients.ProductPricing.ProductPricing20220501
{
    using AmznSellingPartner.Clients.ValidationAttributes;

    using Newtonsoft.Json;

    /// <summary>
    /// Amazon Prime details.
    /// </summary>
    public class PrimeDetails : BaseClass
    {
        /// <summary>
        /// Indicates whether the offer is an Amazon Prime offer.
        /// </summary>
        [JsonProperty("eligibility")]
        [IsRequired]
        public Eligibility Eligibility { get; set; }
    }
}
