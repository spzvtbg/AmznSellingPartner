namespace AmznSellingPartner.Clients.ListingsItems.ListingsItems20210801
{
	using AmznSellingPartner.Clients.Attributes;

	using Newtonsoft.Json;

	using System.Collections.Generic;

	/// <summary>
	/// A listings item.
	/// </summary>
	public class Item : BaseClass
	{
		/// <summary>
		/// A selling partner provided identifier for an Amazon listing.
		/// </summary>
		[IsRequired]
		[JsonProperty("sku")]
		public string Sku { get; set; }

		[JsonProperty("summaries")]
		public ItemSummaries Summaries { get; set; }

		[JsonProperty("attributes")]
		public ItemAttributes Attributes { get; set; }

		[JsonProperty("issues")]
		public ItemIssues Issues { get; set; }

		[JsonProperty("offers")]
		public ItemOffers Offers { get; set; }

		/// <summary>
		/// The fulfillment availability for the listings item.
		/// </summary>
		[JsonProperty("fulfillmentAvailability")]
		public List<FulfillmentAvailability> FulfillmentAvailability { get; set; }

		/// <summary>
		/// The vendor procurement information for the listings item.
		/// </summary>
		[JsonProperty("procurement")]
		public List<ItemProcurement> Procurement { get; set; }

		[JsonProperty("relationships")]
		public ItemRelationships Relationships { get; set; }

		[JsonProperty("productTypes")]
		public ItemProductTypes ProductTypes { get; set; }
	}
}
