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
		[JsonProperty("marketplaceId")]
		[IsRequired]
		public string MarketplaceId { get; set; }

		/// <summary>
		/// Images for an item in the Amazon catalog for the indicated Amazon marketplace.
		/// </summary>
		[JsonProperty("images")]
		[IsRequired]
		public List<ItemImage> Images { get; set; }
	}
}
