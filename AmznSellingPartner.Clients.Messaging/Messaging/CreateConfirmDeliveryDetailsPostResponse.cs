namespace AmznSellingPartner.Clients.Messaging.Messaging
{
	using AmznSellingPartner.Clients.Attributes;

	public class CreateConfirmDeliveryDetailsPostResponse : BaseHttpResponse<CreateConfirmDeliveryDetailsPostResponse>
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
		/// The message was created for the order.
		/// </summary>
		public CreateConfirmDeliveryDetailsResponse CreateConfirmDeliveryDetailsResponse { get; set; } 
	}
}
