namespace AmznSellingPartner.Clients.FbaInventory.FbaInventory
{
	using AmznSellingPartner.Clients.Attributes;

	using Newtonsoft.Json;

	/// <summary>
	/// An item to be created in the inventory.
	/// </summary>
	public class CreateInventoryItemRequest : BaseClass
	{
		/// <summary>
		/// The seller SKU of the item.
		/// </summary>
		[IsRequired]
		[JsonProperty("sellerSku")]
		public string SellerSku { get; set; }

		/// <summary>
		/// The marketplaceId.
		/// </summary>
		[IsRequired]
		[JsonProperty("marketplaceId")]
		public string MarketplaceId { get; set; }

		/// <summary>
		/// The name of the item.
		/// </summary>
		[IsRequired]
		[JsonProperty("productName")]
		public string ProductName { get; set; }
	}
}
