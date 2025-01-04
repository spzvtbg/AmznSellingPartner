namespace AmznSellingPartner.Clients.ListingsItems.ListingsItems20210801
{
	using AmznSellingPartner.Clients.Attributes;

	using Newtonsoft.Json;

	/// <summary>
	/// Offer details of a listings item for an Amazon marketplace.
	/// </summary>
	public class ItemOfferByMarketplace : BaseClass
	{
		/// <summary>
		/// The Amazon marketplace identifier.
		/// </summary>
		[JsonProperty("marketplaceId")]
		[IsRequired]
		public string MarketplaceId { get; set; }

		/// <summary>
		/// Type of offer for the listings item.
		/// </summary>
		[JsonProperty("offerType")]
		[IsRequired]
		public OfferType OfferType { get; set; }

		/// <summary>
		/// The purchase price of the listings item
		/// </summary>
		[JsonProperty("price")]
		[IsRequired]
		public Money Price { get; set; }

		[JsonProperty("points")]
		public Points Points { get; set; }

		/// <summary>
		/// Buyer segment or program this offer is applicable to.
		/// </summary>
		[JsonProperty("audience")]
		public Audience Audience { get; set; }
	}
}
