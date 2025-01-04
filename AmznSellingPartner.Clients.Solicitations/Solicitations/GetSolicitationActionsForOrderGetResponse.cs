namespace AmznSellingPartner.Clients.Solicitations.Solicitations
{
	using AmznSellingPartner.Clients.Attributes;

	public class GetSolicitationActionsForOrderGetResponse : BaseHttpResponse<GetSolicitationActionsForOrderGetResponse>
	{
		/// <summary>
		/// Your rate limit (requests per second) for this operation. _Note:_ For this status code, the rate limit
		/// header is deprecated and no longer returned.
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
		/// Returns hypermedia links under the _links.actions key that specify which solicitation actions are allowed
		/// for the order.
		/// </summary>
		public GetSolicitationActionsForOrderResponse GetSolicitationActionsForOrderResponse { get; set; }
	}
}
