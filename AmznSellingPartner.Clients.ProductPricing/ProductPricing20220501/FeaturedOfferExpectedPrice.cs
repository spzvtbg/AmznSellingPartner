namespace AmznSellingPartner.Clients.ProductPricing.ProductPricing20220501
{
	using AmznSellingPartner.Clients.Attributes;

	using Newtonsoft.Json;

	/// <summary>
	/// The item price at or below which the target offer may be featured.
	/// </summary>
	public class FeaturedOfferExpectedPrice : BaseClass
	{
		/// <summary>
		/// A computed listing price at or below which a seller can expect to become the featured offer (before applicable
		/// promotions).
		/// </summary>
		[IsRequired]
		[JsonProperty("listingPrice")]
		public MoneyType ListingPrice { get; set; }

		/// <summary>
		/// The number of Amazon Points that are offered with the purchase of an item and the monetary value of these
		/// points.
		/// </summary>
		[JsonProperty("points")]
		public Points Points { get; set; }
	}
}
