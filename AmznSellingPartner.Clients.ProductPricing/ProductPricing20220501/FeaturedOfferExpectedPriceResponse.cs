namespace AmznSellingPartner.Clients.ProductPricing.ProductPricing20220501
{
	using AmznSellingPartner.Clients.Attributes;

	using Newtonsoft.Json;

	/// <summary>
	/// Schema for an individual FOEP response.
	/// </summary>
	public class FeaturedOfferExpectedPriceResponse : BaseClass
	{
		/// <summary>
		/// Use these request parameters to map the response back to the request.
		/// </summary>
		[JsonProperty("request")]
		[IsRequired]
		public FeaturedOfferExpectedPriceRequestParams Request { get; set; } 

		[JsonProperty("body")]
		public FeaturedOfferExpectedPriceResponseBody Body { get; set; } 
	}
}
