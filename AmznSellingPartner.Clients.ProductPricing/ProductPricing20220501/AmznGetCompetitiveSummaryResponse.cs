namespace AmznSellingPartner.Clients.ProductPricing.ProductPricing20220501
{
	using AmznSellingPartner.Clients.Attributes;

	using Newtonsoft.Json;

	public class AmznGetCompetitiveSummaryResponse : BaseHttpResponse<AmznGetCompetitiveSummaryResponse>
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
		/// Success.
		/// </summary>
		[HttpStatus(200)]
		public CompetitiveSummaryBatchResponse CompetitiveSummaryBatchResponse { get; set; } 

		/// <summary>
		/// Request has missing or invalid parameters and cannot be parsed. Indicates access to the resource
		/// is forbidden. Possible reasons include Access Denied, Unauthorized, Expired Token, or Invalid
		/// Signature. The specified resource does not exist. The frequency of requests was greater than
		/// allowed. An unexpected condition occurred that prevented the server from fulfilling the request.
		/// Temporary overloading or maintenance of the server.
		/// </summary>
		[HttpStatus(400)]
		[HttpStatus(403)]
		[HttpStatus(404)]
		[HttpStatus(429)]
		[HttpStatus(500)]
		[HttpStatus(503)]
		public Errors Errors { get; set; } 
	}
}
