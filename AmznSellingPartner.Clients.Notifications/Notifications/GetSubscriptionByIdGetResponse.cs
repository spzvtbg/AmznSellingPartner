namespace AmznSellingPartner.Clients.Notifications.Notifications
{
	using Newtonsoft.Json;

	public class GetSubscriptionByIdGetResponse : BaseHttpResponse<GetSubscriptionByIdGetResponse>
	{
		/// <summary>
		/// Your rate limit (requests per second) for this operation. _Note:_ For this status code, the rate limit
		/// header is deprecated and no longer returned.
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
		public GetSubscriptionByIdResponse GetSubscriptionByIdResponse { get; set; } 

		/// <summary>
		/// The resource specified does not exist.
		/// </summary>
		public GetSubscriptionResponse GetSubscriptionResponse { get; set; } 
	}
}
