namespace AmznSellingPartner.Clients.Sales.Sales
{
	using Newtonsoft.Json;

	public class GetOrderMetricsGetResponse : BaseHttpResponse<GetOrderMetricsGetResponse>
	{
		[JsonProperty("Is200")]
		public bool Is200 { get; set; }

		/// <summary>
		/// Your rate limit (requests per second) for this operation
		/// _Note:_ For this status code, the rate limit header is deprecated and no longer returned
		/// </summary>
		[JsonProperty("x-amzn-RateLimit-Limit")]
		public string XAmznRateLimitLimit { get; set; }

		/// <summary>
		/// Unique request reference id
		/// </summary>
		[JsonProperty("x-amzn-RequestId")]
		public string XAmznRequestId { get; set; }

		/// <summary>
		/// OrderMetric action taken on the resource OrderMetrics
		/// </summary>
		[JsonProperty("Value200")]
		public GetOrderMetricsResponse Value200 { get; set; }

		[JsonProperty("Is400")]
		public bool Is400 { get; set; }

		/// <summary>
		/// Request has missing or invalid parameters and cannot be parsed
		/// </summary>
		[JsonProperty("Value400")]
		public GetOrderMetricsResponse Value400 { get; set; }

		[JsonProperty("Is403")]
		public bool Is403 { get; set; }

		/// <summary>
		/// 403 can be caused for reasons like Access Denied, Unauthorized, Expired Token, Invalid Signature or Resource N
		/// t Found
		/// </summary>
		[JsonProperty("Value403")]
		public GetOrderMetricsResponse Value403 { get; set; }

		[JsonProperty("Is404")]
		public bool Is404 { get; set; }

		/// <summary>
		/// The resource specified does not exist
		/// </summary>
		[JsonProperty("Value404")]
		public GetOrderMetricsResponse Value404 { get; set; }

		[JsonProperty("Is413")]
		public bool Is413 { get; set; }

		/// <summary>
		/// The request size exceeded the maximum accepted size
		/// </summary>
		[JsonProperty("Value413")]
		public GetOrderMetricsResponse Value413 { get; set; }

		[JsonProperty("Is415")]
		public bool Is415 { get; set; }

		/// <summary>
		/// The entity of the request is in a format not supported by the requested resource
		/// </summary>
		[JsonProperty("Value415")]
		public GetOrderMetricsResponse Value415 { get; set; }

		[JsonProperty("Is429")]
		public bool Is429 { get; set; }

		/// <summary>
		/// The frequency of requests was greater than allowed
		/// </summary>
		[JsonProperty("Value429")]
		public GetOrderMetricsResponse Value429 { get; set; }

		[JsonProperty("Is500")]
		public bool Is500 { get; set; }

		/// <summary>
		/// Encountered an unexpected condition which prevented the server from fulfilling the request
		/// </summary>
		[JsonProperty("Value500")]
		public GetOrderMetricsResponse Value500 { get; set; }

		[JsonProperty("Is503")]
		public bool Is503 { get; set; }

		/// <summary>
		/// Temporary overloading or maintenance of the server
		/// </summary>
		[JsonProperty("Value503")]
		public GetOrderMetricsResponse Value503 { get; set; }
	}
}
