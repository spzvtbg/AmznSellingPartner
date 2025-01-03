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
		[IsRequired]
		[JsonProperty("sellerId")]
		public string SellerId { get; set; }

		/// <summary>
		/// Item Condition.
		/// </summary>
		[IsRequired]
		[JsonProperty("condition")]
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
		[IsRequired]
		[JsonProperty("fulfillmentType")]
		public FulfillmentType FulfillmentType { get; set; }

		/// <summary>
		/// The offer buying price. This doesn't include shipping, points, or applicable promotions.
		/// </summary>
		[IsRequired]
		[JsonProperty("listingPrice")]
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
