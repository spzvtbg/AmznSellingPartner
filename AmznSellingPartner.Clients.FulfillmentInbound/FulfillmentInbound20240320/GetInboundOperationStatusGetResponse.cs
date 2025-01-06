namespace AmznSellingPartner.Clients.FulfillmentInbound.FulfillmentInbound20240320
{
	using Newtonsoft.Json;

	public class GetInboundOperationStatusGetResponse : BaseHttpResponse<GetInboundOperationStatusGetResponse>
	{
		/// <summary>
		/// Unique request reference identifier.
		/// </summary>
		[JsonProperty("x-amzn-requestid")]
		public string XAmznRequestid { get; set; } 

		/// <summary>
		/// Your rate limit (requests per second) for this operation.
		/// </summary>
		[JsonProperty("x-amzn-ratelimit-limit")]
		public string XAmznRatelimitLimit { get; set; } 

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
