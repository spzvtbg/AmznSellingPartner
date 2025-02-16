namespace AmznSellingPartner.Clients.AplusContent.AplusContent20201101
{
    using AmznSellingPartner.Clients.ValidationAttributes;

    using Newtonsoft.Json;

    /// <summary>
    /// The A+ Content document. This is the enhanced content that is published to product detail
    /// pages.
    /// </summary>
    public class ContentDocument : BaseClass
    {
        /// <summary>
        /// The A+ Content document name.
        /// </summary>
        [JsonProperty("name")]
        [IsRequired]
        [MinLength(1)]
        [MaxLength(100)]
        public string Name { get; set; }

        [JsonProperty("contentType")]
        [IsRequired]
        public ContentType ContentType { get; set; }

        [JsonProperty("contentSubType")]
        public ContentSubType ContentSubType { get; set; }

        [JsonProperty("locale")]
        [IsRequired]
        public LanguageTag Locale { get; set; }

        [JsonProperty("contentModuleList")]
        [IsRequired]
        public ContentModuleList ContentModuleList { get; set; }
    }
}
