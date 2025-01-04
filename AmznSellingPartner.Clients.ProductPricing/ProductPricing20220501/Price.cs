namespace AmznSellingPartner.Clients.ProductPricing.ProductPricing20220501
{
	using AmznSellingPartner.Clients.Attributes;

	using Newtonsoft.Json;

	/// <summary>
	/// The schema for item's price information, including listing price, shipping price, and Amazon Points.
	/// </summary>
	public class Price : BaseClass
	{
		/// <summary>
		/// The listing price for the item, excluding any promotions.
		/// </summary>
		[JsonProperty("listingPrice")]
		[IsRequired]
		public MoneyType ListingPrice { get; set; }

		/// <summary>
		/// The shipping cost of the product. Note that the shipping cost is not always available.
		/// </summary>
		[JsonProperty("shippingPrice")]
		public MoneyType ShippingPrice { get; set; }

		/// <summary>
		/// The number of Amazon Points that are offered with the purchase of an item and the monetary value of these
		/// points.
		/// </summary>
		[JsonProperty("points")]
		public Points Points { get; set; }
	}
}
