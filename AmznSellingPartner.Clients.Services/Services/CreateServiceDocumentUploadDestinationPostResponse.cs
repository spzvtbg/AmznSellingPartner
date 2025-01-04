namespace AmznSellingPartner.Clients.Services.Services
{
	using AmznSellingPartner.Clients.Attributes;

	public class CreateServiceDocumentUploadDestinationPostResponse : BaseHttpResponse
	{
		/// <summary>
		/// Your rate limit (requests per second) for this operation. **Note:** For this status code, the rate limit
		/// header is deprecated and no longer returned.
		/// </summary>
		[FromHeader("x-amzn-RateLimit-Limit")]
		public string XAmznRateLimitLimit { get; set; } 

		/// <summary>
		/// Unique request reference id.
		/// </summary>
		[FromHeader("x-amzn-RequestId")]
		public string XAmznRequestId { get; set; } 

		/// <summary>
		/// Successfully created an upload destination for the given resource.
		/// </summary>
		public CreateServiceDocumentUploadDestination CreateServiceDocumentUploadDestination { get; set; } 
	}
}
