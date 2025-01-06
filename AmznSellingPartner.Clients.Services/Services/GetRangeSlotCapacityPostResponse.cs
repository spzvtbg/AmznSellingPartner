namespace AmznSellingPartner.Clients.Services.Services
{
	using Newtonsoft.Json;

	public class GetRangeSlotCapacityPostResponse : BaseHttpResponse<GetRangeSlotCapacityPostResponse>
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
		/// Success response.
		/// </summary>
		public RangeSlotCapacity RangeSlotCapacity { get; set; } 

		/// <summary>
		/// Request has missing or invalid parameters and cannot be parsed.
		/// </summary>
		public RangeSlotCapacityErrors RangeSlotCapacityErrors { get; set; } 
	}
}
