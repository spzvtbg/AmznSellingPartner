namespace AmznSellingPartner.Clients.AplusContent.AplusContent20201101
{
    using AmznSellingPartner.Clients.ValidationAttributes;

    using Newtonsoft.Json;

    /// <summary>
    /// A content document with additional information for content management.
    /// </summary>
    public class ContentRecord : BaseClass
    {
        [JsonProperty("contentReferenceKey")]
        [IsRequired]
        public ContentReferenceKey ContentReferenceKey { get; set; }

        [JsonProperty("contentMetadata")]
        public ContentMetadata ContentMetadata { get; set; }

        [JsonProperty("contentDocument")]
        public ContentDocument ContentDocument { get; set; }
    }
}
