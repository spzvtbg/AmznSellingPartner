namespace AmznSellingPartner.Clients.AplusContent.AplusContent20201101
{
    using AmznSellingPartner.Clients.ValidationAttributes;

    using Newtonsoft.Json;

    public class GetContentDocumentResponse : BaseClass
    {
        [JsonProperty("contentRecord")]
        [IsRequired]
        public ContentRecord ContentRecord { get; set; }
    }
}
