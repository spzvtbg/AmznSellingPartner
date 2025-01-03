namespace AmznSellingPartner.Clients.ProductPricing.ProductPricing20220501
{
	using AmznSellingPartner.Clients.Attributes;

	using Newtonsoft.Json;

	/// <summary>
	/// Identifies an offer from a particular seller for a specified ASIN.
	/// </summary>
	public class OfferIdentifier : BaseClass
	{
		/// <summary>
		/// A marketplace identifier.
		/// </summary>
		[IsRequired]
		[JsonProperty("marketplaceId")]
		public MarketplaceId MarketplaceId { get; set; }

		/// <summary>
		/// The seller identifier for the offer.
		/// </summary>
		[JsonProperty("sellerId")]
		public string SellerId { get; set; }

		/// <summary>
		/// The seller SKU of the item. This will only be present for the target offer, which belongs to the requesting
		/// seller.
		/// </summary>
		[JsonProperty("sku")]
		public string Sku { get; set; }

		/// <summary>
		/// The Amazon identifier for the item.
		/// </summary>
		[IsRequired]
		[JsonProperty("asin")]
		public Asin Asin { get; set; }

		/// <summary>
		/// The fulfillment type for the offer.
		/// </summary>
		[JsonProperty("fulfillmentType")]
		public FulfillmentType FulfillmentType { get; set; }
	}
}
