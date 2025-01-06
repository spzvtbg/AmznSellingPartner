namespace AmznSellingPartner.Clients.VendorOrders.VendorOrders
{
	using Newtonsoft.Json;

	public class GetPurchaseOrderGetResponse : BaseHttpResponse<GetPurchaseOrderGetResponse>
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
		public GetPurchaseOrderResponse GetPurchaseOrderResponse { get; set; } 
	}
}
