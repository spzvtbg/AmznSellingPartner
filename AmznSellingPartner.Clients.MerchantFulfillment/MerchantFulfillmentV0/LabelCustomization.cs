namespace AmznSellingPartner.Clients.MerchantFulfillment.MerchantFulfillmentV0
{
    using Newtonsoft.Json;

    /// <summary>
    /// Custom text for shipping labels.
    /// </summary>
    public class LabelCustomization : BaseClass
    {
        [JsonProperty("CustomTextForLabel")]
        public CustomTextForLabel CustomTextForLabel { get; set; }

        [JsonProperty("StandardIdForLabel")]
        public StandardIdForLabel StandardIdForLabel { get; set; }
    }
}
