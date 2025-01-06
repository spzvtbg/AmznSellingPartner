namespace AmznSellingPartner.Clients.Messaging.Messaging
{
	using Newtonsoft.Json;

	public class GetMessagingActionsForOrderGetResponse : BaseHttpResponse<GetMessagingActionsForOrderGetResponse>
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
		/// Returns hypermedia links under the _links.actions key that specify which messaging actions are allowed
		/// for the order.
		/// </summary>
		public GetMessagingActionsForOrderResponse GetMessagingActionsForOrderResponse { get; set; } 
	}
}
