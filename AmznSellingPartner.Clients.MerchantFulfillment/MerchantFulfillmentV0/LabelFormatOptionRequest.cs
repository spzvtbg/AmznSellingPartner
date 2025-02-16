namespace AmznSellingPartner.Clients.MerchantFulfillment.MerchantFulfillmentV0
{
    using Newtonsoft.Json;

    /// <summary>
    /// Whether to include a packing slip.
    /// </summary>
    public class LabelFormatOptionRequest : BaseClass
    {
        /// <summary>
        /// When true, include a packing slip with the label.
        /// </summary>
        [JsonProperty("IncludePackingSlipWithLabel")]
        public bool IncludePackingSlipWithLabel { get; set; }
    }
}
