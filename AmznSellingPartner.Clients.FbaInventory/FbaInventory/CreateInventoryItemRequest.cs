namespace AmznSellingPartner.Clients.FbaInventory.FbaInventory
{
    using AmznSellingPartner.Clients.ValidationAttributes;

    using Newtonsoft.Json;

    /// <summary>
    /// An item to be created in the inventory.
    /// </summary>
    public class CreateInventoryItemRequest : BaseClass
    {
        /// <summary>
        /// The seller SKU of the item.
        /// </summary>
        [JsonProperty("sellerSku")]
        [IsRequired]
        public string SellerSku { get; set; }

        /// <summary>
        /// The marketplaceId.
        /// </summary>
        [JsonProperty("marketplaceId")]
        [IsRequired]
        public string MarketplaceId { get; set; }

        /// <summary>
        /// The name of the item.
        /// </summary>
        [JsonProperty("productName")]
        [IsRequired]
        public string ProductName { get; set; }
    }
}
