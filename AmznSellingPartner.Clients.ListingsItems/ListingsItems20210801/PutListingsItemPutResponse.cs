namespace AmznSellingPartner.Clients.ListingsItems.ListingsItems20210801
{
	using AmznSellingPartner.Clients.Attributes;

	public class PutListingsItemPutResponse : BaseHttpResponse
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
		/// Successfully understood the request to create or fully-update a listings item. See the response to determine
		/// if the submission has been accepted.
		/// </summary>
		public ListingsItemSubmissionResponse ListingsItemSubmissionResponse { get; set; } 

		/// <summary>
		/// Request has missing or invalid parameters and cannot be parsed.
		/// </summary>
		public ErrorList ErrorList { get; set; } 
	}
}
