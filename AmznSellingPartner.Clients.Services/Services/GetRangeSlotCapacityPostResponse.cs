namespace AmznSellingPartner.Clients.Services.Services
{
	using AmznSellingPartner.Clients.Attributes;

	public class GetRangeSlotCapacityPostResponse : BaseHttpResponse
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
		public RangeSlotCapacity RangeSlotCapacity { get; set; } 

		/// <summary>
		/// Request has missing or invalid parameters and cannot be parsed.
		/// </summary>
		public RangeSlotCapacityErrors RangeSlotCapacityErrors { get; set; } 
	}
}
