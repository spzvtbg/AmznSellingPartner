namespace AmznSellingPartner.Clients.FbaInventory.FbaInventory
{
	using AmznSellingPartner.Clients.Attributes;

	using Newtonsoft.Json;

	public class AmznGetInventorySummariesResponse : BaseHttpResponse<AmznGetInventorySummariesResponse>
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
		/// OK Request has missing or invalid parameters and cannot be parsed. Indicates access to the
		/// resource is forbidden. Possible reasons include Access Denied, Unauthorized, Expired Token,
		/// Invalid Signature or Resource Not Found. The specified resource does not exist. The frequency
		/// of requests was greater than allowed. An unexpected condition occurred that prevented the server
		/// from fulfilling the request. Temporary overloading or maintenance of the server.
		/// </summary>
		[HttpStatus(200)]
		[HttpStatus(400)]
		[HttpStatus(403)]
		[HttpStatus(404)]
		[HttpStatus(429)]
		[HttpStatus(500)]
		[HttpStatus(503)]
		public GetInventorySummariesResponse GetInventorySummariesResponse { get; set; } 
	}
}
