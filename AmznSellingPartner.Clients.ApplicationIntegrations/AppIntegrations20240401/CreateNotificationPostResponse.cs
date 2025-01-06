namespace AmznSellingPartner.Clients.ApplicationIntegrations.AppIntegrations20240401
{
	using Newtonsoft.Json;

	public class CreateNotificationPostResponse : BaseHttpResponse<CreateNotificationPostResponse>
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
		/// Successful creation of notification with the identifier captured in response.
		/// </summary>
		public CreateNotificationResponse CreateNotificationResponse { get; set; } 

		/// <summary>
		/// Request has missing or invalid parameters and cannot be parsed.
		/// </summary>
		public ErrorList ErrorList { get; set; } 
	}
}
