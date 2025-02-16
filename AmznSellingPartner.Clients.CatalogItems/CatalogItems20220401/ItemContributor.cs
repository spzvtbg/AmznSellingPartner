namespace AmznSellingPartner.Clients.CatalogItems.CatalogItems20220401
{
    using AmznSellingPartner.Clients.ValidationAttributes;

    using Newtonsoft.Json;

    /// <summary>
    /// Individual contributor to the creation of an item, such as an author or actor.
    /// </summary>
    public class ItemContributor : BaseClass
    {
        [JsonProperty("role")]
        [IsRequired]
        public ItemContributorRole Role { get; set; }

        /// <summary>
        /// Name of the contributor, such as Jane Austen.
        /// </summary>
        [JsonProperty("value")]
        [IsRequired]
        public string Value { get; set; }
    }
}
