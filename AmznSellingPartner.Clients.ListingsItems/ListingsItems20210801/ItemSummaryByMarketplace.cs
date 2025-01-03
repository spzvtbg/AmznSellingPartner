namespace AmznSellingPartner.Clients.ListingsItems.ListingsItems20210801
{
	using AmznSellingPartner.Clients.Attributes;

	using Newtonsoft.Json;

	using System;
	using System.Collections.Generic;

	/// <summary>
	/// Summary details of a listings item for an Amazon marketplace.
	/// </summary>
	public class ItemSummaryByMarketplace : BaseClass
	{
		/// <summary>
		/// A marketplace identifier. Identifies the Amazon marketplace for the listings item.
		/// </summary>
		[IsRequired]
		[JsonProperty("marketplaceId")]
		public string MarketplaceId { get; set; }

		/// <summary>
		/// Amazon Standard Identification Number (ASIN) of the listings item.
		/// </summary>
		[JsonProperty("asin")]
		public string Asin { get; set; }

		/// <summary>
		/// The Amazon product type of the listings item.
		/// </summary>
		[IsRequired]
		[JsonProperty("productType")]
		public string ProductType { get; set; }

		/// <summary>
		/// Identifies the condition of the listings item.
		/// </summary>
		[JsonProperty("conditionType")]
		public ConditionType ConditionType { get; set; }

		/// <summary>
		/// Statuses that apply to the listings item.
		/// </summary>
		[IsRequired]
		[JsonProperty("status")]
		public List<Status> Status { get; set; }

		/// <summary>
		/// The fulfillment network stock keeping unit is an identifier used by Amazon fulfillment centers to identify
		/// each unique item.
		/// </summary>
		[JsonProperty("fnSku")]
		public string FnSku { get; set; }

		/// <summary>
		/// The name or title associated with an Amazon catalog item.
		/// </summary>
		[JsonProperty("itemName")]
		public string ItemName { get; set; }

		/// <summary>
		/// The date the listings item was created in ISO 8601 format.
		/// </summary>
		[IsRequired]
		[JsonProperty("createdDate")]
		public DateTime CreatedDate { get; set; }

		/// <summary>
		/// The date the listings item was last updated in ISO 8601 format.
		/// </summary>
		[IsRequired]
		[JsonProperty("lastUpdatedDate")]
		public DateTime LastUpdatedDate { get; set; }

		/// <summary>
		/// The main image for the listings item.
		/// </summary>
		[JsonProperty("mainImage")]
		public ItemImage MainImage { get; set; }
	}
}
