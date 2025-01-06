namespace AmznSellingPartner.Clients.FbaInboundEligibility.FbaInbound
{
	using Newtonsoft.Json;

	public class GetItemEligibilityPreviewGetResponse : BaseHttpResponse<GetItemEligibilityPreviewGetResponse>
	{
		/// <summary>
		/// Your rate limit (requests per second) for this operation. _Note:_ For this status code, the rate limit
		/// header is deprecated and no longer returned.
		/// </summary>
		[JsonProperty("x-amzn-ratelimit-limit")]
		public string XAmznRatelimitLimit { get; set; } 

		/// <summary>
		/// Unique request reference ID.
		/// </summary>
		[JsonProperty("x-amzn-requestid")]
		public string XAmznRequestid { get; set; } 

		/// <summary>
		/// Success.
		/// </summary>
		public GetItemEligibilityPreviewResponse GetItemEligibilityPreviewResponse { get; set; } 
	}
}
