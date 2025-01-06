namespace AmznSellingPartner.Clients.FbaInventory.FbaInventory
{
	using Newtonsoft.Json;

	public class GetInventorySummariesGetResponse : BaseHttpResponse<GetInventorySummariesGetResponse>
	{
		/// <summary>
		/// Your rate limit (requests per second) for this operation.
		/// </summary>
		[JsonProperty("x-amzn-ratelimit-limit")]
		public string XAmznRatelimitLimit { get; set; } 

		/// <summary>
		/// Unique request reference identifier.
		/// </summary>
		[JsonProperty("x-amzn-requestid")]
		public string XAmznRequestid { get; set; } 

		/// <summary>
		/// OK
		/// </summary>
		public GetInventorySummariesResponse GetInventorySummariesResponse { get; set; } 
	}
}
