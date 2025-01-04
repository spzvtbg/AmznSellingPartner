namespace AmznSellingPartner.Clients.FbaInventory.FbaInventory
{
	using AmznSellingPartner.Clients.Attributes;

	public class GetInventorySummariesGetResponse : BaseHttpResponse<GetInventorySummariesGetResponse>
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

		public bool Succeeded { get; set; } 

		/// <summary>
		/// OK
		/// </summary>
		public GetInventorySummariesResponse GetInventorySummariesResponse { get; set; } 
	}
}
