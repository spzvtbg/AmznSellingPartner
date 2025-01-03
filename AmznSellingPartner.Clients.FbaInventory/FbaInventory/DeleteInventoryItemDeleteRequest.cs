namespace AmznSellingPartner.Clients.FbaInventory.FbaInventory
{
	using AmznSellingPartner.Clients.Attributes;

	using Newtonsoft.Json;

	[HttpDelete("/fba/inventory/v1/items/{sellerSku}")]
	public class DeleteInventoryItemDeleteRequest : BaseHttpRequest
	{
		/// <summary>
		/// A single seller SKU used for querying the specified seller SKU inventory summaries
		/// </summary>
		[InPath("sellerSku")]
		[IsRequired]
		[JsonProperty("sellerSku")]
		public string SellerSku { get; set; }

		/// <summary>
		/// The marketplace ID for the marketplace for which the sellerSku is to be deleted
		/// </summary>
		[InQuery("marketplaceId")]
		[IsRequired]
		[JsonProperty("marketplaceId")]
		public string MarketplaceId { get; set; }
	}
}
