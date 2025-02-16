namespace AmznSellingPartner.Clients.ListingsItems.ListingsItems20210801
{
    using AmznSellingPartner.Clients.ValidationAttributes;

    using Newtonsoft.Json;

    using System.Collections.Generic;

    /// <summary>
    /// An issue with a listings item.
    /// </summary>
    public class Issue : BaseClass
    {
        /// <summary>
        /// An issue code that identifies the type of issue.
        /// </summary>
        [JsonProperty("code")]
        [IsRequired]
        public string Code { get; set; }

        /// <summary>
        /// A message that describes the issue.
        /// </summary>
        [JsonProperty("message")]
        [IsRequired]
        public string Message { get; set; }

        /// <summary>
        /// The severity of the issue.
        /// </summary>
        [JsonProperty("severity")]
        [IsRequired]
        public Severity Severity { get; set; }

        /// <summary>
        /// The names of the attributes associated with the issue, if applicable.
        /// </summary>
        [JsonProperty("attributeNames")]
        public List<string> AttributeNames { get; set; }

        /// <summary>
        /// List of issue categories.   Possible vales:   * `INVALID_ATTRIBUTE` - Indicating an invalid
        /// attribute in the listing.   * `MISSING_ATTRIBUTE` - Highlighting a missing attribute in the
        /// listing.   * `INVALID_IMAGE` - Signifying an invalid image in the listing.   * `MISSING_IMAGE`
        /// - Noting the absence of an image in the listing.   * `INVALID_PRICE` - Pertaining to issues
        /// with the listing's price-related attributes.   * `MISSING_PRICE` - Pointing out the absence
        /// of a price attribute in the listing.   * `DUPLICATE` - Identifying listings with potential
        /// duplicate problems, such as this ASIN potentially being a duplicate of another ASIN.   * `QUALIFICATION_REQUIRED`
        /// - Indicating that the listing requires qualification-related approval.
        /// </summary>
        [JsonProperty("categories")]
        [IsRequired]
        public List<string> Categories { get; set; }

        /// <summary>
        /// This field provides information about the enforcement actions taken by Amazon that affect the
        /// publishing or status of a listing. It also includes details about any associated exemption
        /// s.
        /// </summary>
        [JsonProperty("enforcements")]
        public IssueEnforcements Enforcements { get; set; }
    }
}
