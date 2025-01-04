namespace AmznSellingPartner.Clients.Services.Services
{
	using AmznSellingPartner.Clients.Attributes;

	public class CreateReservationPostResponse : BaseHttpResponse<CreateReservationPostResponse>
	{
		/// <summary>
		/// Your rate limit (requests per second) for this operation. **Note:** For this status code, the rate limit
		/// header is deprecated and no longer returned.
		/// </summary>
		[FromHeader("x-amzn-RateLimit-Limit")]
		public string XAmznRateLimitLimit { get; set; } 

		/// <summary>
		/// Unique request reference identifier.
		/// </summary>
		[FromHeader("x-amzn-RequestId")]
		public string XAmznRequestId { get; set; } 

		public bool Succeeded { get; set; } 

		/// <summary>
		/// Success response.
		/// </summary>
		public CreateReservationResponse CreateReservationResponse { get; set; } 
	}
}
