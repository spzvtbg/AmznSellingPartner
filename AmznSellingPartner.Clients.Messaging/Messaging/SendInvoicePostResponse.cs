namespace AmznSellingPartner.Clients.Messaging.Messaging
{
	using Newtonsoft.Json;

	public class SendInvoicePostResponse : BaseHttpResponse<SendInvoicePostResponse>
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
		/// The message was created for the order.
		/// </summary>
		public InvoiceResponse InvoiceResponse { get; set; } 
	}
}
