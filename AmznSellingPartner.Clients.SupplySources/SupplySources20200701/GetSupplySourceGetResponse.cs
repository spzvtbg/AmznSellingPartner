namespace AmznSellingPartner.Clients.SupplySources.SupplySources20200701
{
	using AmznSellingPartner.Clients.Attributes;

	public class GetSupplySourceGetResponse : BaseHttpResponse<GetSupplySourceGetResponse>
	{
		/// <summary>
		/// Your rate limit (requests per second) for this operation. _Note:_ For this status code, the rate limit
		/// header is deprecated and no longer returned.
		/// </summary>
		[FromHeader("x-amzn-RateLimit-Limit")]
		public string XAmznRateLimitLimit { get; set; }

		/// <summary>
		/// The unique request reference ID.
		/// </summary>
		[FromHeader("x-amzn-RequestId")]
		public string XAmznRequestId { get; set; }

		public bool Succeeded { get; set; }

		/// <summary>
		/// Success.
		/// </summary>
		public SupplySource SupplySource { get; set; }

		/// <summary>
		/// The request has missing or invalid parameters and cannot be parsed.
		/// </summary>
		public ErrorList ErrorList { get; set; }
	}
}
