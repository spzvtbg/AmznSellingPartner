namespace AmznSellingPartner.Clients.Services.Services
{
	using Newtonsoft.Json;

	public class CompleteServiceJobByServiceJobIdPutResponse : BaseHttpResponse<CompleteServiceJobByServiceJobIdPutResponse>
	{
		/// <summary>
		/// Your rate limit (requests per second) for this operation. **Note:** For this status code, the rate limit
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
		/// Success response.
		/// </summary>
		public CompleteServiceJobByServiceJobIdResponse CompleteServiceJobByServiceJobIdResponse { get; set; } 
	}
}
