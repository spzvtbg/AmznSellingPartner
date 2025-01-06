namespace AmznSellingPartner.Clients.FulfillmentOutbound.FulfillmentOutbound20200701
{
	using Newtonsoft.Json;

	public class GetFulfillmentPreviewPostResponse : BaseHttpResponse<GetFulfillmentPreviewPostResponse>
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
		public GetFulfillmentPreviewResponse GetFulfillmentPreviewResponse { get; set; } 
	}
}
