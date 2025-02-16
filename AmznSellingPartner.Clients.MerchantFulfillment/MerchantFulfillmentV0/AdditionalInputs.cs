namespace AmznSellingPartner.Clients.MerchantFulfillment.MerchantFulfillmentV0
{
    using Newtonsoft.Json;

    /// <summary>
    /// Maps the additional seller input to the definition. The key to the map is the field name.
    /// </summary>
    public class AdditionalInputs : BaseClass
    {
        /// <summary>
        /// The field name.
        /// </summary>
        [JsonProperty("AdditionalInputFieldName")]
        public string AdditionalInputFieldName { get; set; }

        [JsonProperty("SellerInputDefinition")]
        public SellerInputDefinition SellerInputDefinition { get; set; }
    }
}
