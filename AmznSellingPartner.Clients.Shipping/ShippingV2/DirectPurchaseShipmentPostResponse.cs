namespace AmznSellingPartner.Clients.Shipping.ShippingV2
{
	using AmznSellingPartner.Clients.Attributes;

	public class DirectPurchaseShipmentPostResponse : BaseHttpResponse<DirectPurchaseShipmentPostResponse>
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

		/// <summary>
		/// A unique value which the server uses to recognize subsequent retries of the same request.
		/// </summary>
		[FromHeader("x-amzn-IdempotencyKey")]
		public string XAmznIdempotencyKey { get; set; }

		public bool Succeeded { get; set; }

		/// <summary>
		/// Success
		/// </summary>
		public DirectPurchaseResponse DirectPurchaseResponse { get; set; }

		/// <summary>
		/// Request has missing or invalid parameters and cannot be parsed.
		/// </summary>
		public ErrorList ErrorList { get; set; }
	}
}
