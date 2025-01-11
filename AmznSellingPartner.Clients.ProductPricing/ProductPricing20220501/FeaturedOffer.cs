namespace AmznSellingPartner.Clients.ProductPricing.ProductPricing20220501
{
	using AmznSellingPartner.Clients.Attributes;

	using Newtonsoft.Json;

	/// <summary>
	/// Schema for `currentFeaturedOffer` or `competingFeaturedOffer`.
	/// </summary>
	public class FeaturedOffer : BaseClass
	{
		/// <summary>
		/// An offer identifier used to identify the merchant of the featured offer. Since this may not
		/// belong to the requester, the SKU field is omitted.
		/// </summary>
		[JsonProperty("offerIdentifier")]
		[IsRequired]
		public OfferIdentifier OfferIdentifier { get; set; } 

		/// <summary>
		/// The item condition.
		/// </summary>
		[JsonProperty("condition")]
		public Condition Condition { get; set; } 

		/// <summary>
		/// The current active price of the offer.
		/// </summary>
		[JsonProperty("price")]
		public Price Price { get; set; } 
	}
}
