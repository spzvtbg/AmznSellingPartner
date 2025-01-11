namespace AmznSellingPartner.Clients.CatalogItems.CatalogItems20220401
{
	using AmznSellingPartner.Clients.Attributes;

	using Newtonsoft.Json;

	using System.Collections.Generic;

	/// <summary>
	/// Classifications (browse nodes) associated with the item in the Amazon catalog for the indicated
	/// Amazon marketplace.
	/// </summary>
	public class ItemBrowseClassificationsByMarketplace : BaseClass
	{
		/// <summary>
		/// Amazon marketplace identifier.
		/// </summary>
		[JsonProperty("marketplaceId")]
		[IsRequired]
		public string MarketplaceId { get; set; } 

		/// <summary>
		/// Classifications (browse nodes) associated with the item in the Amazon catalog for the indicated
		/// Amazon marketplace.
		/// </summary>
		[JsonProperty("classifications")]
		public List<ItemBrowseClassification> Classifications { get; set; } 
	}
}
