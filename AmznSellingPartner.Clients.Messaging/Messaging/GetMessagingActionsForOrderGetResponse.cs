namespace AmznSellingPartner.Clients.Messaging.Messaging
{
	using AmznSellingPartner.Clients.Attributes;

	public class GetMessagingActionsForOrderGetResponse : BaseHttpResponse<GetMessagingActionsForOrderGetResponse>
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
		/// Returns hypermedia links under the _links.actions key that specify which messaging actions are allowed
		/// for the order.
		/// </summary>
		public GetMessagingActionsForOrderResponse GetMessagingActionsForOrderResponse { get; set; }
	}
}
