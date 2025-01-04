namespace AmznSellingPartner.Clients.VendorTransactionStatus.VendorTransactionStatus
{
	using AmznSellingPartner.Clients.Attributes;

	public class GetTransactionGetResponse : BaseHttpResponse<GetTransactionGetResponse>
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
		public GetTransactionResponse GetTransactionResponse { get; set; } 
	}
}
