namespace AmznSellingPartner.Clients.CatalogItems.CatalogItems20220401
{
	using AmznSellingPartner.Clients.Attributes;

	using Newtonsoft.Json;

	using System.Collections.Generic;

	/// <summary>
	/// Images for an item in the Amazon catalog for the indicated Amazon marketplace.
	/// </summary>
	public class ItemImagesByMarketplace : BaseClass
	{
		/// <summary>
		/// Amazon marketplace identifier.
		/// </summary>
		[IsRequired]
		[JsonProperty("marketplaceId")]
		public string MarketplaceId { get; set; }

		/// <summary>
		/// Images for an item in the Amazon catalog for the indicated Amazon marketplace.
		/// </summary>
		[IsRequired]
		[JsonProperty("images")]
		public List<ItemImage> Images { get; set; }
	}
}
