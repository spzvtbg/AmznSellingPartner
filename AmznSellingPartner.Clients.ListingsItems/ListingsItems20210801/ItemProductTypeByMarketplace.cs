namespace AmznSellingPartner.Clients.ListingsItems.ListingsItems20210801
{
	using AmznSellingPartner.Clients.Attributes;

	using Newtonsoft.Json;

	/// <summary>
	/// Product types that are associated with the listing item for the specified marketplace.
	/// </summary>
	public class ItemProductTypeByMarketplace : BaseClass
	{
		/// <summary>
		/// Amazon marketplace identifier.
		/// </summary>
		[JsonProperty("marketplaceId")]
		[IsRequired]
		public string MarketplaceId { get; set; }

		/// <summary>
		/// The name of the product type that is submitted by the Selling Partner.
		/// </summary>
		[JsonProperty("productType")]
		[IsRequired]
		public string ProductType { get; set; }
	}
}
