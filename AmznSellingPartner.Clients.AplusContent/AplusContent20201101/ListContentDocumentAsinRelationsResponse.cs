namespace AmznSellingPartner.Clients.AplusContent.AplusContent20201101
{
    using AmznSellingPartner.Clients.ValidationAttributes;

    using Newtonsoft.Json;

    public class ListContentDocumentAsinRelationsResponse : BaseClass
    {
        [JsonProperty("asinMetadataSet")]
        [IsRequired]
        public AsinMetadataSet AsinMetadataSet { get; set; }
    }
}
