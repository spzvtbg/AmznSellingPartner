namespace AmznSellingPartner.Clients.Sales.Sales
{
	using AmznSellingPartner.Clients.Attributes;

	public class GetOrderMetricsGetResponse : BaseHttpResponse<GetOrderMetricsGetResponse>
	{
		/// <summary>
		/// Your rate limit (requests per second) for this operation. _Note:_ For this status code, the rate limit
		/// header is deprecated and no longer returned.
		/// </summary>
		[FromHeader("x-amzn-RateLimit-Limit")]
		public string XAmznRateLimitLimit { get; set; } 

		/// <summary>
		/// Unique request reference id.
		/// </summary>
		[FromHeader("x-amzn-RequestId")]
		public string XAmznRequestId { get; set; } 

		public bool Succeeded { get; set; } 

		/// <summary>
		/// OrderMetric action taken on the resource OrderMetrics.
		/// </summary>
		public GetOrderMetricsResponse GetOrderMetricsResponse { get; set; } 
	}
}
