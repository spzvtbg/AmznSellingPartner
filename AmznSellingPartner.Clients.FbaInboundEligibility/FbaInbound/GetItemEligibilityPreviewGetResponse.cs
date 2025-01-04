namespace AmznSellingPartner.Clients.FbaInboundEligibility.FbaInbound
{
	using AmznSellingPartner.Clients.Attributes;

	public class GetItemEligibilityPreviewGetResponse : BaseHttpResponse
	{
		/// <summary>
		/// Your rate limit (requests per second) for this operation. _Note:_ For this status code, the rate limit
		/// header is deprecated and no longer returned.
		/// </summary>
		[FromHeader("x-amzn-RateLimit-Limit")]
		public string XAmznRateLimitLimit { get; set; } 

		/// <summary>
		/// Unique request reference ID.
		/// </summary>
		[FromHeader("x-amzn-RequestId")]
		public string XAmznRequestId { get; set; } 

		/// <summary>
		/// Success.
		/// </summary>
		public GetItemEligibilityPreviewResponse GetItemEligibilityPreviewResponse { get; set; } 
	}
}
