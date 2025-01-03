namespace AmznSellingPartner.Clients.CatalogItems.CatalogItems20220401
{
	using AmznSellingPartner.Clients.Attributes;

	using Newtonsoft.Json;

	using System.Collections.Generic;

	/// <summary>
	/// Identifiers associated with the item in the Amazon catalog for the indicated Amazon marketplace.
	/// </summary>
	public class ItemIdentifiersByMarketplace : BaseClass
	{
		/// <summary>
		/// Amazon marketplace identifier.
		/// </summary>
		[IsRequired]
		[JsonProperty("marketplaceId")]
		public string MarketplaceId { get; set; }

		/// <summary>
		/// Identifiers associated with the item in the Amazon catalog for the indicated Amazon marketplace.
		/// </summary>
		[IsRequired]
		[JsonProperty("identifiers")]
		public List<ItemIdentifier> Identifiers { get; set; }
	}
}
