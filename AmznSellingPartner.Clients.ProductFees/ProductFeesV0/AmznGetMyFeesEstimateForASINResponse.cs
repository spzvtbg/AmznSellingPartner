namespace AmznSellingPartner.Clients.ProductFees.ProductFeesV0
{
	using AmznSellingPartner.Clients.Attributes;

	using Newtonsoft.Json;

	public class AmznGetMyFeesEstimateForASINResponse : BaseHttpResponse<AmznGetMyFeesEstimateForASINResponse>
	{
		/// <summary>
		/// Your rate limit (requests per second) for this operation. _Note:_ For this status code, the
		/// rate limit header is deprecated and no longer returned.
		/// </summary>
		[JsonProperty("x-amzn-ratelimit-limit")]
		public string XAmznRatelimitLimit { get; set; } 

		/// <summary>
		/// Unique request reference identifier.
		/// </summary>
		[JsonProperty("x-amzn-requestid")]
		public string XAmznRequestid { get; set; } 

		/// <summary>
		/// Success. Request has missing or invalid parameters and cannot be parsed. The request's Authorization
		/// header is not formatted correctly or does not contain a valid token. Indicates access to the
		/// resource is forbidden. Possible reasons include Access Denied, Unauthorized, Expired Token,
		/// or Invalid Signature. The specified resource does not exist. The frequency of requests was
		/// greater than allowed. An unexpected condition occurred that prevented the server from fulfilling
		/// the request. Temporary overloading or maintenance of the server.
		/// </summary>
		[HttpStatus(200)]
		[HttpStatus(400)]
		[HttpStatus(401)]
		[HttpStatus(403)]
		[HttpStatus(404)]
		[HttpStatus(429)]
		[HttpStatus(500)]
		[HttpStatus(503)]
		public GetMyFeesEstimateResponse GetMyFeesEstimateResponse { get; set; } 
	}
}
