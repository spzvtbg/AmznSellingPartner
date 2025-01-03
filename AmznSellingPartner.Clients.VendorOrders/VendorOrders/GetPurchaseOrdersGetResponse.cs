namespace AmznSellingPartner.Clients.VendorOrders.VendorOrders
{
	using Newtonsoft.Json;

	public class GetPurchaseOrdersGetResponse : BaseHttpResponse<GetPurchaseOrdersGetResponse>
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
		public GetPurchaseOrdersResponse Value200 { get; set; }

		[JsonProperty("Is400")]
		public bool Is400 { get; set; }

		/// <summary>
		/// Request has missing or invalid parameters and cannot be parsed.
		/// </summary>
		[JsonProperty("Value400")]
		public GetPurchaseOrdersResponse Value400 { get; set; }

		[JsonProperty("Is403")]
		public bool Is403 { get; set; }

		/// <summary>
		/// Indicates that access to the resource is forbidden. Possible reasons include Access Denied, Unauthorized, Expi
		/// ed Token, or Invalid Signature.
		/// </summary>
		[JsonProperty("Value403")]
		public GetPurchaseOrdersResponse Value403 { get; set; }

		[JsonProperty("Is404")]
		public bool Is404 { get; set; }

		/// <summary>
		/// The resource specified does not exist.
		/// </summary>
		[JsonProperty("Value404")]
		public GetPurchaseOrdersResponse Value404 { get; set; }

		[JsonProperty("Is415")]
		public bool Is415 { get; set; }

		/// <summary>
		/// The request payload is in an unsupported format.
		/// </summary>
		[JsonProperty("Value415")]
		public GetPurchaseOrdersResponse Value415 { get; set; }

		[JsonProperty("Is429")]
		public bool Is429 { get; set; }

		/// <summary>
		/// The frequency of requests was greater than allowed.
		/// </summary>
		[JsonProperty("Value429")]
		public GetPurchaseOrdersResponse Value429 { get; set; }

		[JsonProperty("Is500")]
		public bool Is500 { get; set; }

		/// <summary>
		/// An unexpected condition occurred that prevented the server from fulfilling the request.
		/// </summary>
		[JsonProperty("Value500")]
		public GetPurchaseOrdersResponse Value500 { get; set; }

		[JsonProperty("Is503")]
		public bool Is503 { get; set; }

		/// <summary>
		/// Temporary overloading or maintenance of the server.
		/// </summary>
		[JsonProperty("Value503")]
		public GetPurchaseOrdersResponse Value503 { get; set; }
	}
}
