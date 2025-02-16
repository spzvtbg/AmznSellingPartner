namespace AmznSellingPartner.Clients.MerchantFulfillment.MerchantFulfillmentV0
{
    using Newtonsoft.Json;

    /// <summary>
    /// Filter for use when requesting eligible shipping services.
    /// </summary>
    public class ShippingOfferingFilter : BaseClass
    {
        /// <summary>
        /// When true, include a packing slip with the label.
        /// </summary>
        [JsonProperty("IncludePackingSlipWithLabel")]
        public bool IncludePackingSlipWithLabel { get; set; }

        /// <summary>
        /// When true, include complex shipping options.
        /// </summary>
        [JsonProperty("IncludeComplexShippingOptions")]
        public bool IncludeComplexShippingOptions { get; set; }

        [JsonProperty("CarrierWillPickUp")]
        public CarrierWillPickUpOption CarrierWillPickUp { get; set; }

        [JsonProperty("DeliveryExperience")]
        public DeliveryExperienceOption DeliveryExperience { get; set; }
    }
}
