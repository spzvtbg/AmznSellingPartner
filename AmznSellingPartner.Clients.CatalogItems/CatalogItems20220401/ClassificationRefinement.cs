namespace AmznSellingPartner.Clients.CatalogItems.CatalogItems20220401
{
    using AmznSellingPartner.Clients.ValidationAttributes;

    using Newtonsoft.Json;

    /// <summary>
    /// Description of a classification that can be used to get more fine-grained search results.
    /// </summary>
    public class ClassificationRefinement : BaseClass
    {
        /// <summary>
        /// The estimated number of results that would still be returned if refinement key applied.
        /// </summary>
        [JsonProperty("numberOfResults")]
        [IsRequired]
        public int NumberOfResults { get; set; }

        /// <summary>
        /// Display name for the classification.
        /// </summary>
        [JsonProperty("displayName")]
        [IsRequired]
        public string DisplayName { get; set; }

        /// <summary>
        /// Identifier for the classification that can be used for search refinement purposes.
        /// </summary>
        [JsonProperty("classificationId")]
        [IsRequired]
        public string ClassificationId { get; set; }
    }
}
