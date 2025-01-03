namespace AmznSellingPartner.Clients.ProductPricing.ProductPricing20220501
{
	using Newtonsoft.Json;

	/// <summary>
	/// The response schema for the `getFeaturedOfferExpectedPriceBatch` operation.
	/// </summary>
	public class GetFeaturedOfferExpectedPriceBatchResponse : BaseClass
	{
		[JsonProperty("responses")]
		public FeaturedOfferExpectedPriceResponseList Responses { get; set; }
	}
}
