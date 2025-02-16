namespace AmznSellingPartner.Clients.FulfillmentInbound.FulfillmentInbound20240320
{
    using AmznSellingPartner.Clients.ValidationAttributes;
    using AmznSellingPartner.Clients.Values;

    using Newtonsoft.Json;

    /// <summary>
    /// Resource to download the requested document.
    /// </summary>
    public class DocumentDownload : BaseClass
    {
        /// <summary>
        /// The type of download. Possible values: `URL`.
        /// </summary>
        [JsonProperty("downloadType")]
        [IsRequired]
        public string DownloadType { get; set; }

        /// <summary>
        /// The URI's expiration time. In [ISO 8601](https://developer-docs.amazon.com/sp-api/docs/iso-8601)
        /// datetime format with pattern `yyyy-MM-ddTHH:mm:ss.sssZ`.
        /// </summary>
        [JsonProperty("expiration")]
        public DateTimeValue Expiration { get; set; }

        /// <summary>
        /// Uniform resource identifier to identify where the document is located.
        /// </summary>
        [JsonProperty("uri")]
        [IsRequired]
        public string Uri { get; set; }
    }
}
