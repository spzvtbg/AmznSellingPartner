namespace AmznSellingPartner.Clients.FulfillmentOutbound.FulfillmentOutbound20200701
{
	using AmznSellingPartner.Clients.Attributes;

	public class GetFeatureSKUGetResponse : BaseHttpResponse
	{
		/// <summary>
		/// Your rate limit (requests per second) for this operation.
		/// </summary>
		[FromHeader("x-amzn-RateLimit-Limit")]
		public string XAmznRateLimitLimit { get; set; } 

		/// <summary>
		/// Unique request reference identifier.
		/// </summary>
		[FromHeader("x-amzn-RequestId")]
		public string XAmznRequestId { get; set; } 

		/// <summary>
		/// Success.
		/// </summary>
		public GetFeatureSkuResponse GetFeatureSkuResponse { get; set; } 
	}
}
