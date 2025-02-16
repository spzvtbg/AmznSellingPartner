namespace AmznSellingPartner.Clients.MerchantFulfillment.MerchantFulfillmentV0
{
    using AmznSellingPartner.Clients.ValidationAttributes;

    using Newtonsoft.Json;

    /// <summary>
    /// Indicates whether the carrier will pick up the package, and what fee is charged, if any.
    /// </summary>
    public class AvailableCarrierWillPickUpOption : BaseClass
    {
        [JsonProperty("CarrierWillPickUpOption")]
        [IsRequired]
        public CarrierWillPickUpOption CarrierWillPickUpOption { get; set; }

        /// <summary>
        /// The fee charged.
        /// </summary>
        [JsonProperty("Charge")]
        [IsRequired]
        public CurrencyAmount Charge { get; set; }
    }
}
