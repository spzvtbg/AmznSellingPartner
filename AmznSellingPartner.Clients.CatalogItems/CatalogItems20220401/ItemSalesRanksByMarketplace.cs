namespace AmznSellingPartner.Clients.CatalogItems.CatalogItems20220401
{
	using AmznSellingPartner.Clients.Attributes;

	using Newtonsoft.Json;

	using System.Collections.Generic;

	/// <summary>
	/// Sales ranks of an Amazon catalog item for the indicated Amazon marketplace.
	/// </summary>
	public class ItemSalesRanksByMarketplace : BaseClass
	{
		/// <summary>
		/// Amazon marketplace identifier.
		/// </summary>
		[JsonProperty("marketplaceId")]
		[IsRequired]
		public string MarketplaceId { get; set; }

		/// <summary>
		/// Sales ranks of an Amazon catalog item for an Amazon marketplace by classification.
		/// </summary>
		[JsonProperty("classificationRanks")]
		public List<ItemClassificationSalesRank> ClassificationRanks { get; set; }

		/// <summary>
		/// Sales ranks of an Amazon catalog item for an Amazon marketplace by website display group.
		/// </summary>
		[JsonProperty("displayGroupRanks")]
		public List<ItemDisplayGroupSalesRank> DisplayGroupRanks { get; set; }
	}
}
