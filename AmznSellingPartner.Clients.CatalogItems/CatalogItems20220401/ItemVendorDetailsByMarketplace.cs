namespace AmznSellingPartner.Clients.CatalogItems.CatalogItems20220401
{
	using AmznSellingPartner.Clients.Attributes;

	using Newtonsoft.Json;

	/// <summary>
	/// Vendor details associated with an Amazon catalog item for the indicated Amazon marketplace
	/// </summary>
	public class ItemVendorDetailsByMarketplace : BaseClass
	{
		/// <summary>
		/// Amazon marketplace identifier
		/// </summary>
		[IsRequired]
		[JsonProperty("marketplaceId")]
		public string MarketplaceId { get; set; }

		/// <summary>
		/// Brand code associated with an Amazon catalog item
		/// </summary>
		[JsonProperty("brandCode")]
		public string BrandCode { get; set; }

		/// <summary>
		/// Manufacturer code associated with an Amazon catalog item
		/// </summary>
		[JsonProperty("manufacturerCode")]
		public string ManufacturerCode { get; set; }

		/// <summary>
		/// Parent vendor code of the manufacturer code
		/// </summary>
		[JsonProperty("manufacturerCodeParent")]
		public string ManufacturerCodeParent { get; set; }

		/// <summary>
		/// Product category associated with an Amazon catalog item
		/// </summary>
		[JsonProperty("productCategory")]
		public ItemVendorDetailsCategory ProductCategory { get; set; }

		/// <summary>
		/// Product group associated with an Amazon catalog item
		/// </summary>
		[JsonProperty("productGroup")]
		public string ProductGroup { get; set; }

		/// <summary>
		/// Product subcategory associated with an Amazon catalog item
		/// </summary>
		[JsonProperty("productSubcategory")]
		public ItemVendorDetailsCategory ProductSubcategory { get; set; }

		/// <summary>
		/// Replenishment category associated with an Amazon catalog item
		/// </summary>
		[JsonProperty("replenishmentCategory")]
		public ReplenishmentCategory ReplenishmentCategory { get; set; }
	}
}
