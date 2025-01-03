namespace AmznSellingPartner.Clients.CatalogItems.CatalogItems20220401
{
	using AmznSellingPartner.Clients.Attributes;

	using Newtonsoft.Json;

	using System.Collections.Generic;

	/// <summary>
	/// Relationship details for the Amazon catalog item for the indicated Amazon marketplace
	/// </summary>
	public class ItemRelationshipsByMarketplace : BaseClass
	{
		/// <summary>
		/// Amazon marketplace identifier
		/// </summary>
		[IsRequired]
		[JsonProperty("marketplaceId")]
		public string MarketplaceId { get; set; }

		/// <summary>
		/// Relationships for the item
		/// </summary>
		[IsRequired]
		[JsonProperty("relationships")]
		public List<ItemRelationship> Relationships { get; set; }
	}
}
