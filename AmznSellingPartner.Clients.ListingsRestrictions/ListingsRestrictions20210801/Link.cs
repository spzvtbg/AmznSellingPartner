namespace AmznSellingPartner.Clients.ListingsRestrictions.ListingsRestrictions20210801
{
    using AmznSellingPartner.Clients.ValidationAttributes;

    using Newtonsoft.Json;

    /// <summary>
    /// A link to resources related to a listing restriction.
    /// </summary>
    public class Link : BaseClass
    {
        /// <summary>
        /// The URI of the related resource.
        /// </summary>
        [JsonProperty("resource")]
        [IsRequired]
        public string Resource { get; set; }

        /// <summary>
        /// The HTTP verb used to interact with the related resource.
        /// </summary>
        [JsonProperty("verb")]
        [IsRequired]
        public Verb Verb { get; set; }

        /// <summary>
        /// The title of the related resource.
        /// </summary>
        [JsonProperty("title")]
        public string Title { get; set; }

        /// <summary>
        /// The media type of the related resource.
        /// </summary>
        [JsonProperty("type")]
        public string Type { get; set; }
    }
}
