namespace AmznSellingPartner.Clients.Feeds.Feeds20210630
{
	using AmznSellingPartner.Clients.Attributes;

	public class CreateFeedDocumentPostResponse : BaseHttpResponse<CreateFeedDocumentPostResponse>
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
		/// Successfully created a feed document that is ready to receive contents.
		/// </summary>
		public CreateFeedDocumentResponse CreateFeedDocumentResponse { get; set; }

		/// <summary>
		/// Request has missing or invalid parameters and cannot be parsed.
		/// </summary>
		public ErrorList ErrorList { get; set; }
	}
}
