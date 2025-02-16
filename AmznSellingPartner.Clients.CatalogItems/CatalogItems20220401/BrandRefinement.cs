namespace AmznSellingPartner.Clients.CatalogItems.CatalogItems20220401
{
    using AmznSellingPartner.Clients.ValidationAttributes;

    using Newtonsoft.Json;

    /// <summary>
    /// Description of a brand that can be used to get more fine-grained search results.
    /// </summary>
    public class BrandRefinement : BaseClass
    {
        /// <summary>
        /// The estimated number of results that would still be returned if refinement key applied.
        /// </summary>
        [JsonProperty("numberOfResults")]
        [IsRequired]
        public int NumberOfResults { get; set; }

        /// <summary>
        /// Brand name. For display and can be used as a search refinement.
        /// </summary>
        [JsonProperty("brandName")]
        [IsRequired]
        public string BrandName { get; set; }
    }
}
