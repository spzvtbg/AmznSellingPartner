namespace AmznSellingPartner.Clients.Sellers.Sellers
{
	using AmznSellingPartner.Clients.Attributes;

	public class GetMarketplaceParticipationsGetResponse : BaseHttpResponse<GetMarketplaceParticipationsGetResponse>
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
		/// Marketplace participations successfully retrieved.
		/// </summary>
		public GetMarketplaceParticipationsResponse GetMarketplaceParticipationsResponse { get; set; } 
	}
}
