namespace AmznSellingPartner.Clients.Feeds.Feeds20210630
{
	using Newtonsoft.Json;

	public class CreateFeedDocumentPostResponse : BaseHttpResponse<CreateFeedDocumentPostResponse>
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
		/// Successfully created a feed document that is ready to receive contents.
		/// </summary>
		public CreateFeedDocumentResponse CreateFeedDocumentResponse { get; set; } 

		/// <summary>
		/// Request has missing or invalid parameters and cannot be parsed.
		/// </summary>
		public ErrorList ErrorList { get; set; } 
	}
}
