namespace AmznSellingPartner.Clients.VendorShipments.VendorShipments
{
	using Newtonsoft.Json;

	public class SubmitShipmentsPostResponse : BaseHttpResponse<SubmitShipmentsPostResponse>
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
		public SubmitShipmentConfirmationsResponse SubmitShipmentConfirmationsResponse { get; set; } 
	}
}
