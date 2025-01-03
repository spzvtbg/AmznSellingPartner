namespace AmznSellingPartner.Clients.FbaInventory.FbaInventory
{
	using AmznSellingPartner.Clients.Attributes;

	using Newtonsoft.Json;

	/// <summary>
	/// An item in the list of inventory to be added
	/// </summary>
	public class InventoryItem : BaseClass
	{
		/// <summary>
		/// The seller SKU of the item
		/// </summary>
		[IsRequired]
		[JsonProperty("sellerSku")]
		public string SellerSku { get; set; }

		/// <summary>
		/// The marketplaceId
		/// </summary>
		[IsRequired]
		[JsonProperty("marketplaceId")]
		public string MarketplaceId { get; set; }

		/// <summary>
		/// The quantity of item to add
		/// </summary>
		[IsRequired]
		[JsonProperty("quantity")]
		public int Quantity { get; set; }
	}
}
