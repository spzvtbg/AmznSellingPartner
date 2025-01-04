namespace AmznSellingPartner.Clients.FbaInventory.FbaInventory
{
	using AmznSellingPartner.Clients.Attributes;

	using Newtonsoft.Json;

	/// <summary>
	/// An item in the list of inventory to be added.
	/// </summary>
	public class InventoryItem : BaseClass
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
		/// The quantity of item to add.
		/// </summary>
		[JsonProperty("quantity")]
		[IsRequired]
		public int Quantity { get; set; }
	}
}
