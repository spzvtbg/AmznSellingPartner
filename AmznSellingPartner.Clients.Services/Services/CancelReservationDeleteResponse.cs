namespace AmznSellingPartner.Clients.Services.Services
{
	using Newtonsoft.Json;

	public class CancelReservationDeleteResponse : BaseHttpResponse<CancelReservationDeleteResponse>
	{
		/// <summary>
		/// Your rate limit (requests per second) for this operation. **Note:** For this status code, the rate limit
		/// header is deprecated and no longer returned.
		/// </summary>
		[JsonProperty("x-amzn-ratelimit-limit")]
		public string XAmznRatelimitLimit { get; set; } 

		/// <summary>
		/// Unique request reference id.
		/// </summary>
		[JsonProperty("x-amzn-requestid")]
		public string XAmznRequestid { get; set; } 

		/// <summary>
		/// Success response.
		/// </summary>
		public CancelReservationResponse CancelReservationResponse { get; set; } 
	}
}
