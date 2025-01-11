namespace AmznSellingPartner.Clients.CatalogItems.CatalogItems20220401
{
	using AmznSellingPartner.Clients.Attributes;

	using Newtonsoft.Json;

	using System.Collections.Generic;

	/// <summary>
	/// Identifiers associated with the item in the Amazon catalog for the indicated Amazon market
	/// place.
	/// </summary>
	public class ItemIdentifiersByMarketplace : BaseClass
	{
		/// <summary>
		/// Amazon marketplace identifier.
		/// </summary>
		[JsonProperty("marketplaceId")]
		[IsRequired]
		public string MarketplaceId { get; set; } 

		/// <summary>
		/// Identifiers associated with the item in the Amazon catalog for the indicated Amazon market
		/// place.
		/// </summary>
		[JsonProperty("identifiers")]
		[IsRequired]
		public List<ItemIdentifier> Identifiers { get; set; } 
	}
}
