namespace AmznSellingPartner.Clients.Sales.Sales
{
	using Newtonsoft.Json;

	public class GetOrderMetricsGetResponse : BaseHttpResponse<GetOrderMetricsGetResponse>
	{
		/// <summary>
		/// Your rate limit (requests per second) for this operation. _Note:_ For this status code, the rate limit
		/// header is deprecated and no longer returned.
		/// </summary>
		[JsonProperty("x-amzn-ratelimit-limit")]
		public string XAmznRatelimitLimit { get; set; } 

		/// <summary>
		/// Unique request reference id.
		/// </summary>
		[JsonProperty("x-amzn-requestid")]
		public string XAmznRequestid { get; set; } 

		/// <summary>
		/// OrderMetric action taken on the resource OrderMetrics.
		/// </summary>
		public GetOrderMetricsResponse GetOrderMetricsResponse { get; set; } 
	}
}
