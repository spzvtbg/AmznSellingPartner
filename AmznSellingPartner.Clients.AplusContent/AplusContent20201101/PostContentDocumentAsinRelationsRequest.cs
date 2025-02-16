namespace AmznSellingPartner.Clients.AplusContent.AplusContent20201101
{
    using AmznSellingPartner.Clients.ValidationAttributes;

    using Newtonsoft.Json;

    public class PostContentDocumentAsinRelationsRequest : BaseClass
    {
        [JsonProperty("asinSet")]
        [IsRequired]
        public AsinSet AsinSet { get; set; }
    }
}
