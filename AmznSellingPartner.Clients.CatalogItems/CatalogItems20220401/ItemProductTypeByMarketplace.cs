namespace AmznSellingPartner.Clients.CatalogItems.CatalogItems20220401
{
    using Newtonsoft.Json;

    /// <summary>
    /// Product type associated with the Amazon catalog item for the indicated Amazon marketplace.
    /// </summary>
    public class ItemProductTypeByMarketplace : BaseClass
    {
        /// <summary>
        /// Amazon marketplace identifier.
        /// </summary>
        [JsonProperty("marketplaceId")]
        public string MarketplaceId { get; set; }

        /// <summary>
        /// Name of the product type associated with the Amazon catalog item.
        /// </summary>
        [JsonProperty("productType")]
        public string ProductType { get; set; }
    }
}
