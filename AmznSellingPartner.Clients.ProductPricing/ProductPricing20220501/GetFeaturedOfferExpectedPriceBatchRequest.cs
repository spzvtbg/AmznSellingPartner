namespace AmznSellingPartner.Clients.ProductPricing.ProductPricing20220501
{
	using Newtonsoft.Json;

	/// <summary>
	/// The request body for the `getFeaturedOfferExpectedPriceBatch` operation.
	/// </summary>
	public class GetFeaturedOfferExpectedPriceBatchRequest : BaseClass
	{
		[JsonProperty("requests")]
		public FeaturedOfferExpectedPriceRequestList Requests { get; set; } 
	}
}
