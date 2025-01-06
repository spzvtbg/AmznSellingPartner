namespace AmznSellingPartner.Clients.Shipping.ShippingV2
{
	using Newtonsoft.Json;

	public class DirectPurchaseShipmentPostResponse : BaseHttpResponse<DirectPurchaseShipmentPostResponse>
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
		/// A unique value which the server uses to recognize subsequent retries of the same request.
		/// </summary>
		[JsonProperty("x-amzn-idempotencykey")]
		public string XAmznIdempotencykey { get; set; } 

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
