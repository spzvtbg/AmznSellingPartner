namespace AmznSellingPartner.Clients.ApplicationManagement.Application20231130
{
	using Newtonsoft.Json;

	public class RotateApplicationClientSecretPostResponse : BaseHttpResponse<RotateApplicationClientSecretPostResponse>
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
		/// Success.
		/// </summary>
		public object Object { get; set; } 

		/// <summary>
		/// Application is not enrolled for rotation notification. Please update application notification preference
		/// in Developer console.
		/// </summary>
		public ErrorList ErrorList { get; set; } 
	}
}
