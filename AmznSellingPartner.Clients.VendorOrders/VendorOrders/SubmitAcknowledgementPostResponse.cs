namespace AmznSellingPartner.Clients.VendorOrders.VendorOrders
{
	using AmznSellingPartner.Clients.Attributes;

	public class SubmitAcknowledgementPostResponse : BaseHttpResponse
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
		public SubmitAcknowledgementResponse SubmitAcknowledgementResponse { get; set; } 
	}
}
