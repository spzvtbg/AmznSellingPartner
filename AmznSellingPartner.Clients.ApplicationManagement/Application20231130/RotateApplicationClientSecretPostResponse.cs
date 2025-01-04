namespace AmznSellingPartner.Clients.ApplicationManagement.Application20231130
{
	using AmznSellingPartner.Clients.Attributes;

	public class RotateApplicationClientSecretPostResponse : BaseHttpResponse<RotateApplicationClientSecretPostResponse>
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
		public object Object { get; set; } 

		/// <summary>
		/// Application is not enrolled for rotation notification. Please update application notification preference
		/// in Developer console.
		/// </summary>
		public ErrorList ErrorList { get; set; } 
	}
}
