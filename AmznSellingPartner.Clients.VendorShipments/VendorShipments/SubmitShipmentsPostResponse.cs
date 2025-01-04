namespace AmznSellingPartner.Clients.VendorShipments.VendorShipments
{
	using AmznSellingPartner.Clients.Attributes;

	public class SubmitShipmentsPostResponse : BaseHttpResponse
	{
		/// <summary>
		/// Your rate limit (requests per second) for this operation.
		/// </summary>
		[FromHeader("x-amzn-RateLimit-Limit")]
		public string XAmznRateLimitLimit { get; set; } 

		/// <summary>
		/// Unique request reference identifier.
		/// </summary>
		[FromHeader("x-amzn-RequestId")]
		public string XAmznRequestId { get; set; } 

		/// <summary>
		/// Success.
		/// </summary>
		public SubmitShipmentConfirmationsResponse SubmitShipmentConfirmationsResponse { get; set; } 
	}
}
