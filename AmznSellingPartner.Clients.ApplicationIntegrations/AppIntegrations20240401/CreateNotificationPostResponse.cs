namespace AmznSellingPartner.Clients.ApplicationIntegrations.AppIntegrations20240401
{
	using AmznSellingPartner.Clients.Attributes;

	public class CreateNotificationPostResponse : BaseHttpResponse<CreateNotificationPostResponse>
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
		/// Successful creation of notification with the identifier captured in response.
		/// </summary>
		public CreateNotificationResponse CreateNotificationResponse { get; set; } 

		/// <summary>
		/// Request has missing or invalid parameters and cannot be parsed.
		/// </summary>
		public ErrorList ErrorList { get; set; } 
	}
}
