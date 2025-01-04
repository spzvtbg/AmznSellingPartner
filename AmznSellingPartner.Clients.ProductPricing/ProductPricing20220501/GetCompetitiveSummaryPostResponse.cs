namespace AmznSellingPartner.Clients.ProductPricing.ProductPricing20220501
{
	using AmznSellingPartner.Clients.Attributes;

	public class GetCompetitiveSummaryPostResponse : BaseHttpResponse<GetCompetitiveSummaryPostResponse>
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

		public bool Succeeded { get; set; }

		/// <summary>
		/// Success.
		/// </summary>
		public CompetitiveSummaryBatchResponse CompetitiveSummaryBatchResponse { get; set; }

		/// <summary>
		/// Request has missing or invalid parameters and cannot be parsed.
		/// </summary>
		public Errors Errors { get; set; }
	}
}
