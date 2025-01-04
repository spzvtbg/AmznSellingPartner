namespace AmznSellingPartner.Clients.ProductPricing.ProductPricing20220501
{
	using AmznSellingPartner.Clients.Attributes;

	using Newtonsoft.Json;

	using System.Collections.Generic;

	/// <summary>
	/// The offer data of a product.
	/// </summary>
	public class Offer : BaseClass
	{
		/// <summary>
		/// The seller identifier for the offer.
		/// </summary>
		[JsonProperty("sellerId")]
		[IsRequired]
		public string SellerId { get; set; }

		/// <summary>
		/// Item Condition.
		/// </summary>
		[JsonProperty("condition")]
		[IsRequired]
		public Condition Condition { get; set; }

		/// <summary>
		/// The item subcondition of the offer.
		/// </summary>
		[JsonProperty("subCondition")]
		public SubCondition SubCondition { get; set; }

		/// <summary>
		/// The fulfillment type for the offer. Possible values are `AFN` (Amazon Fulfillment Network) and `MFN`
		/// (Merchant Fulfillment Network).
		/// </summary>
		[JsonProperty("fulfillmentType")]
		[IsRequired]
		public FulfillmentType FulfillmentType { get; set; }

		/// <summary>
		/// The offer buying price. This doesn't include shipping, points, or applicable promotions.
		/// </summary>
		[JsonProperty("listingPrice")]
		[IsRequired]
		public MoneyType ListingPrice { get; set; }

		/// <summary>
		/// A list of shipping options associated with this offer
		/// </summary>
		[JsonProperty("shippingOptions")]
		public List<ShippingOption> ShippingOptions { get; set; }

		/// <summary>
		/// The number of Amazon Points that are offered with the purchase of an item and the monetary value of these
		/// points. Note that the Points element is only returned in Japan (JP).
		/// </summary>
		[JsonProperty("points")]
		public Points Points { get; set; }

		/// <summary>
		/// Amazon Prime details.
		/// </summary>
		[JsonProperty("primeDetails")]
		public PrimeDetails PrimeDetails { get; set; }
	}
}
