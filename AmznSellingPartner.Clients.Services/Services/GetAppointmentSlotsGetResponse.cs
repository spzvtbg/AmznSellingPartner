namespace AmznSellingPartner.Clients.Services.Services
{
	using AmznSellingPartner.Clients.Attributes;

	public class GetAppointmentSlotsGetResponse : BaseHttpResponse
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
		/// Success response.
		/// </summary>
		public GetAppointmentSlotsResponse GetAppointmentSlotsResponse { get; set; } 
	}
}
