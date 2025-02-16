namespace AmznSellingPartner.Clients.Feeds.Feeds20210630
{
    using AmznSellingPartner.Clients.ValidationAttributes;

    using Newtonsoft.Json;

    /// <summary>
    /// Specifies the content type for the createFeedDocument operation.
    /// </summary>
    public class CreateFeedDocumentSpecification : BaseClass
    {
        /// <summary>
        /// The content type of the feed.
        /// </summary>
        [JsonProperty("contentType")]
        [IsRequired]
        public string ContentType { get; set; }
    }
}
