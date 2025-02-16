namespace AmznSellingPartner.Clients.AplusContent.AplusContent20201101
{
    using AmznSellingPartner.Clients.ValidationAttributes;

    using Newtonsoft.Json;

    /// <summary>
    /// The metadata for an A+ Content document, with additional information for content managemen
    /// t.
    /// </summary>
    public class ContentMetadataRecord : BaseClass
    {
        [JsonProperty("contentReferenceKey")]
        [IsRequired]
        public ContentReferenceKey ContentReferenceKey { get; set; }

        [JsonProperty("contentMetadata")]
        [IsRequired]
        public ContentMetadata ContentMetadata { get; set; }
    }
}
