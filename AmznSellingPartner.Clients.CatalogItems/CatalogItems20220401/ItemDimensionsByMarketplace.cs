namespace AmznSellingPartner.Clients.CatalogItems.CatalogItems20220401
{
	using AmznSellingPartner.Clients.Attributes;

	using Newtonsoft.Json;

	/// <summary>
	/// Dimensions associated with the item in the Amazon catalog for the indicated Amazon marketplace.
	/// </summary>
	public class ItemDimensionsByMarketplace : BaseClass
	{
		/// <summary>
		/// Amazon marketplace identifier.
		/// </summary>
		[JsonProperty("marketplaceId")]
		[IsRequired]
		public string MarketplaceId { get; set; } 

		/// <summary>
		/// Dimensions of an Amazon catalog item.
		/// </summary>
		[JsonProperty("item")]
		public Dimensions Item { get; set; } 

		/// <summary>
		/// Dimensions of an Amazon catalog item in its packaging.
		/// </summary>
		[JsonProperty("package")]
		public Dimensions Package { get; set; } 
	}
}
