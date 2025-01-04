namespace AmznSellingPartner.Clients.FulfillmentInbound.FulfillmentInbound20240320
{
	using AmznSellingPartner.Clients.Attributes;

	public class GetInboundOperationStatusGetResponse : BaseHttpResponse<GetInboundOperationStatusGetResponse>
	{
		/// <summary>
		/// Unique request reference identifier.
		/// </summary>
		[FromHeader("x-amzn-RequestId")]
		public string XAmznRequestId { get; set; } 

		/// <summary>
		/// Your rate limit (requests per second) for this operation.
		/// </summary>
		[FromHeader("x-amzn-RateLimit-Limit")]
		public string XAmznRateLimitLimit { get; set; } 

		public bool Succeeded { get; set; } 

		/// <summary>
		/// GetInboundOperationStatus 200 response
		/// </summary>
		public InboundOperationStatus InboundOperationStatus { get; set; } 

		/// <summary>
		/// Request has missing or invalid parameters and cannot be parsed.
		/// </summary>
		public ErrorList ErrorList { get; set; } 
	}
}
