namespace AmznSellingPartner.Clients.ProductPricing.ProductPricing20220501
{
	using Newtonsoft.Json;

	public class GetFeaturedOfferExpectedPriceBatchPostResponse : BaseHttpResponse<GetFeaturedOfferExpectedPriceBatchPostResponse>
	{
		/// <summary>
		/// Your rate limit (requests per second) for this operation.
		/// </summary>
		[JsonProperty("x-amzn-ratelimit-limit")]
		public string XAmznRatelimitLimit { get; set; } 

		/// <summary>
		/// Unique request reference identifier.
		/// </summary>
		[JsonProperty("x-amzn-requestid")]
		public string XAmznRequestid { get; set; } 

		/// <summary>
		/// Success.
		/// </summary>
		public GetFeaturedOfferExpectedPriceBatchResponse GetFeaturedOfferExpectedPriceBatchResponse { get; set; } 

		/// <summary>
		/// Request has missing or invalid parameters and cannot be parsed.
		/// </summary>
		public Errors Errors { get; set; } 
	}
}
