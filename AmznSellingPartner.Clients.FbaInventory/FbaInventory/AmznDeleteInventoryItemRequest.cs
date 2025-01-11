namespace AmznSellingPartner.Clients.FbaInventory.FbaInventory
{
	using AmznSellingPartner.Clients.Attributes;

	[HttpDelete("/fba/inventory/v1/items/{sellerSku}")]
	public class AmznDeleteInventoryItemRequest : BaseHttpRequest
	{
		/// <summary>
		/// A single seller SKU used for querying the specified seller SKU inventory summaries.
		/// </summary>
		[InPath("sellerSku")]
		[IsRequired]
		public string SellerSku { get; set; } 

		/// <summary>
		/// The marketplace ID for the marketplace for which the sellerSku is to be deleted.
		/// </summary>
		[InQuery("marketplaceId")]
		[IsRequired]
		public string MarketplaceId { get; set; } 
	}
}
