namespace AmznSellingPartner.Clients.ListingsItems.ListingsItems20210801
{
	using Newtonsoft.Json;

	public class PutListingsItemPutResponse : BaseHttpResponse<PutListingsItemPutResponse>
	{
		/// <summary>
		/// Your rate limit (requests per second) for this operation.
		/// </summary>
		[JsonProperty("x-amzn-ratelimit-limit")]
		public string XAmznRatelimitLimit { get; set; } 

		/// <summary>
		/// Unique request reference identifier.
		/// </summary>
		[JsonProperty("x-amzn-requestid")]
		public string XAmznRequestid { get; set; } 

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
