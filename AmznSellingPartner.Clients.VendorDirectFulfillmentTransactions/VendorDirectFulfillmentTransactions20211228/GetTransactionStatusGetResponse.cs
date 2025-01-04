namespace AmznSellingPartner.Clients.VendorDirectFulfillmentTransactions.VendorDirectFulfillmentTransactions20211228
{
	using AmznSellingPartner.Clients.Attributes;

	public class GetTransactionStatusGetResponse : BaseHttpResponse
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
		/// Success.
		/// </summary>
		public TransactionStatus TransactionStatus { get; set; } 

		/// <summary>
		/// Request has missing or invalid parameters and cannot be parsed.
		/// </summary>
		public ErrorList ErrorList { get; set; } 

		/// <summary>
		/// The request's Authorization header is not formatted correctly or does not contain a valid token.
		/// </summary>
		public Error Error { get; set; } 
	}
}
