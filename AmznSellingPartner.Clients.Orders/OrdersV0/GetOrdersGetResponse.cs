namespace AmznSellingPartner.Clients.Orders.OrdersV0
{
	using AmznSellingPartner.Clients.Attributes;

	public class GetOrdersGetResponse : BaseHttpResponse<GetOrdersGetResponse>
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
		public GetOrdersResponse GetOrdersResponse { get; set; }
	}
}
