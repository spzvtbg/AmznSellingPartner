namespace AmznSellingPartner.Clients.Shipping.ShippingV2
{
    using AmznSellingPartner.Clients.ValidationAttributes;

    using Newtonsoft.Json;

    /// <summary>
    /// The post-purchase details of a package that will be shipped using a shipping service.
    /// </summary>
    public class PackageDocumentDetail : BaseClass
    {
        [JsonProperty("packageClientReferenceId")]
        [IsRequired]
        public PackageClientReferenceId PackageClientReferenceId { get; set; }

        [JsonProperty("packageDocuments")]
        [IsRequired]
        public PackageDocumentList PackageDocuments { get; set; }

        [JsonProperty("trackingId")]
        public TrackingId TrackingId { get; set; }
    }
}
