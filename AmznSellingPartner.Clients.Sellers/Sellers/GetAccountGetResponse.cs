namespace AmznSellingPartner.Clients.Sellers.Sellers
{
	using AmznSellingPartner.Clients.Attributes;

	public class GetAccountGetResponse : BaseHttpResponse<GetAccountGetResponse>
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
		/// Success.
		/// </summary>
		public GetAccountResponse GetAccountResponse { get; set; } 
	}
}
