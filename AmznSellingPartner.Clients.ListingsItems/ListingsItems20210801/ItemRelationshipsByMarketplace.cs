namespace AmznSellingPartner.Clients.ListingsItems.ListingsItems20210801
{
	using AmznSellingPartner.Clients.Attributes;

	using Newtonsoft.Json;

	using System.Collections.Generic;

	/// <summary>
	/// Relationship details for the listing item in the specified marketplace.
	/// </summary>
	public class ItemRelationshipsByMarketplace : BaseClass
	{
		/// <summary>
		/// Amazon marketplace identifier.
		/// </summary>
		[JsonProperty("marketplaceId")]
		[IsRequired]
		public string MarketplaceId { get; set; } 

		/// <summary>
		/// Relationships for the listing item.
		/// </summary>
		[JsonProperty("relationships")]
		[IsRequired]
		public List<ItemRelationship> Relationships { get; set; } 
	}
}
