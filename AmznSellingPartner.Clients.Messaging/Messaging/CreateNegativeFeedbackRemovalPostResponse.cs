namespace AmznSellingPartner.Clients.Messaging.Messaging
{
	using Newtonsoft.Json;

	public class CreateNegativeFeedbackRemovalPostResponse : BaseHttpResponse<CreateNegativeFeedbackRemovalPostResponse>
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
		/// The negativeFeedbackRemoval message was created for the order.
		/// </summary>
		public CreateNegativeFeedbackRemovalResponse CreateNegativeFeedbackRemovalResponse { get; set; } 
	}
}
