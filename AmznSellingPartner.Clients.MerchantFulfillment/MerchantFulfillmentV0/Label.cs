namespace AmznSellingPartner.Clients.MerchantFulfillment.MerchantFulfillmentV0
{
    using AmznSellingPartner.Clients.ValidationAttributes;

    using Newtonsoft.Json;

    /// <summary>
    /// Data for creating a shipping label and dimensions for printing the label.
    /// </summary>
    public class Label : BaseClass
    {
        [JsonProperty("CustomTextForLabel")]
        public CustomTextForLabel CustomTextForLabel { get; set; }

        [JsonProperty("Dimensions")]
        [IsRequired]
        public LabelDimensions Dimensions { get; set; }

        [JsonProperty("FileContents")]
        [IsRequired]
        public FileContents FileContents { get; set; }

        [JsonProperty("LabelFormat")]
        public LabelFormat LabelFormat { get; set; }

        [JsonProperty("StandardIdForLabel")]
        public StandardIdForLabel StandardIdForLabel { get; set; }
    }
}
