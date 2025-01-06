namespace AmznSellingPartner.Clients.Sellers.Sellers
{
	using Newtonsoft.Json;

	public class GetMarketplaceParticipationsGetResponse : BaseHttpResponse<GetMarketplaceParticipationsGetResponse>
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
		/// Marketplace participations successfully retrieved.
		/// </summary>
		public GetMarketplaceParticipationsResponse GetMarketplaceParticipationsResponse { get; set; } 
	}
}
