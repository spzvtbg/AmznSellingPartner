namespace AmznSellingPartner.Clients.ProductPricing.ProductPricing20220501
{
	using AmznSellingPartner.Clients.Attributes;

	using Newtonsoft.Json;

	/// <summary>
	/// The FOEP result data for the requested offer.
	/// </summary>
	public class FeaturedOfferExpectedPriceResult : BaseClass
	{
		[JsonProperty("featuredOfferExpectedPrice")]
		public FeaturedOfferExpectedPrice FeaturedOfferExpectedPrice { get; set; } 

		/// <summary>
		/// The status of the FOEP computation. Possible values include `VALID_FOEP`, `NO_COMPETING_OFFER`,
		/// `OFFER_NOT_ELIGIBLE`, `OFFER_NOT_FOUND`, and `ASIN_NOT_ELIGIBLE`. Additional values might be
		/// added in the future.
		/// </summary>
		[JsonProperty("resultStatus")]
		[IsRequired]
		public string ResultStatus { get; set; } 

		/// <summary>
		/// The offer that will likely be the featured offer if the target offer is priced above its FOEP.
		/// If the target offer is currently the featured offer, this property will be different than
		/// `currentFeaturedOffer`.
		/// </summary>
		[JsonProperty("competingFeaturedOffer")]
		public FeaturedOffer CompetingFeaturedOffer { get; set; } 

		/// <summary>
		/// The offer that is currently the featured offer. If the target offer is not currently featured,
		/// then this property will be equal to `competingFeaturedOffer`.
		/// </summary>
		[JsonProperty("currentFeaturedOffer")]
		public FeaturedOffer CurrentFeaturedOffer { get; set; } 
	}
}
