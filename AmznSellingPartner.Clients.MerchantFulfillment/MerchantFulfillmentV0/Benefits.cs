namespace AmznSellingPartner.Clients.MerchantFulfillment.MerchantFulfillmentV0
{
    using Newtonsoft.Json;

    /// <summary>
    /// Benefits that are included and excluded for each shipping offer. Benefits represents services
    /// provided by Amazon (for example, `CLAIMS_PROTECTED`) when sellers purchase shipping through
    /// Amazon. Benefit details are made available for any shipment placed on or after January 1st
    /// 2024 00:00 UTC.
    /// </summary>
    public class Benefits : BaseClass
    {
        [JsonProperty("IncludedBenefits")]
        public IncludedBenefits IncludedBenefits { get; set; }

        [JsonProperty("ExcludedBenefits")]
        public ExcludedBenefits ExcludedBenefits { get; set; }
    }
}
