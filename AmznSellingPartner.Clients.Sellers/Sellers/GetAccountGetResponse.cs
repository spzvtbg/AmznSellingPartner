namespace AmznSellingPartner.Clients.Sellers.Sellers
{
	using Newtonsoft.Json;

	public class GetAccountGetResponse : BaseHttpResponse<GetAccountGetResponse>
	{
		[JsonProperty("Is200")]
		public bool Is200 { get; set; }

		/// <summary>
		/// Your rate limit (requests per second) for this operation.
		/// </summary>
		[JsonProperty("x-amzn-RateLimit-Limit")]
		public string XAmznRateLimitLimit { get; set; }

		/// <summary>
		/// Unique request reference identifier.
		/// </summary>
		[JsonProperty("x-amzn-RequestId")]
		public string XAmznRequestId { get; set; }

		/// <summary>
		/// Success.
		/// </summary>
		[JsonProperty("Value200")]
		public GetAccountResponse Value200 { get; set; }

		[JsonProperty("Is400")]
		public bool Is400 { get; set; }

		/// <summary>
		/// Request has missing or invalid parameters and cannot be parsed.
		/// </summary>
		[JsonProperty("Value400")]
		public GetAccountResponse Value400 { get; set; }

		[JsonProperty("Is403")]
		public bool Is403 { get; set; }

		/// <summary>
		/// Indicates that access to the resource is forbidden. Possible reasons include Access Denied, Unauthorized, Expi
		/// ed Token, or Invalid Signature.
		/// </summary>
		[JsonProperty("Value403")]
		public GetAccountResponse Value403 { get; set; }

		[JsonProperty("Is404")]
		public bool Is404 { get; set; }

		/// <summary>
		/// The resource specified does not exist.
		/// </summary>
		[JsonProperty("Value404")]
		public GetAccountResponse Value404 { get; set; }

		[JsonProperty("Is413")]
		public bool Is413 { get; set; }

		/// <summary>
		/// The request size exceeded the maximum accepted size.
		/// </summary>
		[JsonProperty("Value413")]
		public GetAccountResponse Value413 { get; set; }

		[JsonProperty("Is415")]
		public bool Is415 { get; set; }

		/// <summary>
		/// The request payload is in an unsupported format.
		/// </summary>
		[JsonProperty("Value415")]
		public GetAccountResponse Value415 { get; set; }

		[JsonProperty("Is429")]
		public bool Is429 { get; set; }

		/// <summary>
		/// The frequency of requests was greater than allowed.
		/// </summary>
		[JsonProperty("Value429")]
		public GetAccountResponse Value429 { get; set; }

		[JsonProperty("Is500")]
		public bool Is500 { get; set; }

		/// <summary>
		/// An unexpected condition occurred that prevented the server from fulfilling the request.
		/// </summary>
		[JsonProperty("Value500")]
		public GetAccountResponse Value500 { get; set; }

		[JsonProperty("Is503")]
		public bool Is503 { get; set; }

		/// <summary>
		/// Temporary overloading or maintenance of the server.
		/// </summary>
		[JsonProperty("Value503")]
		public GetAccountResponse Value503 { get; set; }
	}
}
