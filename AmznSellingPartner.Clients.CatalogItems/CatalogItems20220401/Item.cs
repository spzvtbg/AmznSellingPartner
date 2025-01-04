namespace AmznSellingPartner.Clients.CatalogItems.CatalogItems20220401
{
	using AmznSellingPartner.Clients.Attributes;

	using Newtonsoft.Json;

	/// <summary>
	/// An item in the Amazon catalog.
	/// </summary>
	public class Item : BaseClass
	{
		[JsonProperty("asin")]
		[IsRequired]
		public ItemAsin Asin { get; set; }

		[JsonProperty("attributes")]
		public ItemAttributes Attributes { get; set; }

		[JsonProperty("classifications")]
		public ItemBrowseClassifications Classifications { get; set; }

		[JsonProperty("dimensions")]
		public ItemDimensions Dimensions { get; set; }

		[JsonProperty("identifiers")]
		public ItemIdentifiers Identifiers { get; set; }

		[JsonProperty("images")]
		public ItemImages Images { get; set; }

		[JsonProperty("productTypes")]
		public ItemProductTypes ProductTypes { get; set; }

		[JsonProperty("relationships")]
		public ItemRelationships Relationships { get; set; }

		[JsonProperty("salesRanks")]
		public ItemSalesRanks SalesRanks { get; set; }

		[JsonProperty("summaries")]
		public ItemSummaries Summaries { get; set; }

		[JsonProperty("vendorDetails")]
		public ItemVendorDetails VendorDetails { get; set; }
	}
}
