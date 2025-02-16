namespace AmznSellingPartner.Clients.AplusContent.AplusContent20201101
{
    using AmznSellingPartner.Clients.ValidationAttributes;

    using Newtonsoft.Json;

    public class PostContentDocumentRequest : BaseClass
    {
        [JsonProperty("contentDocument")]
        [IsRequired]
        public ContentDocument ContentDocument { get; set; }
    }
}
