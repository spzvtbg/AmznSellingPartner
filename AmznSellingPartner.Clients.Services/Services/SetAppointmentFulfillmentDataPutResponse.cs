namespace AmznSellingPartner.Clients.Services.Services
{
	using AmznSellingPartner.Clients.Attributes;

	public class SetAppointmentFulfillmentDataPutResponse : BaseHttpResponse
	{
		/// <summary>
		/// Your rate limit (requests per second) for this operation. **Note:** For this status code, the rate limit
		/// header is deprecated and no longer returned.
		/// </summary>
		[FromHeader("x-amzn-RateLimit-Limit")]
		public string XAmznRateLimitLimit { get; set; } 

		/// <summary>
		/// Unique request reference id.
		/// </summary>
		[FromHeader("x-amzn-RequestId")]
		public string XAmznRequestId { get; set; } 

		/// <summary>
		/// Success response.
		/// </summary>
		public object Object { get; set; } 

		/// <summary>
		/// Request has missing or invalid parameters and cannot be parsed.
		/// </summary>
		public ErrorList ErrorList { get; set; } 
	}
}
