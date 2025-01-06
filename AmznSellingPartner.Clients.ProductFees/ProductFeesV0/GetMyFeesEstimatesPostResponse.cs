namespace AmznSellingPartner.Clients.ProductFees.ProductFeesV0
{
	using Newtonsoft.Json;

	public class GetMyFeesEstimatesPostResponse : BaseHttpResponse<GetMyFeesEstimatesPostResponse>
	{
		/// <summary>
		/// Your rate limit (requests per second) for this operation. _Note:_ For this status code, the rate limit
		/// header is deprecated and no longer returned.
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
		public GetMyFeesEstimatesResponse GetMyFeesEstimatesResponse { get; set; } 

		/// <summary>
		/// Request has missing or invalid parameters and cannot be parsed.
		/// </summary>
		public GetMyFeesEstimatesErrorList GetMyFeesEstimatesErrorList { get; set; } 
	}
}
