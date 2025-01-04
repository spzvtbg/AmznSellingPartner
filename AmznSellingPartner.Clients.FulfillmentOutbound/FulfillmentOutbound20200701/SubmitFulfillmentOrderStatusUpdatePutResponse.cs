namespace AmznSellingPartner.Clients.FulfillmentOutbound.FulfillmentOutbound20200701
{
	using AmznSellingPartner.Clients.Attributes;

	public class SubmitFulfillmentOrderStatusUpdatePutResponse : BaseHttpResponse
	{
		/// <summary>
		/// Unique request reference identifier.
		/// </summary>
		[FromHeader("x-amzn-RequestId")]
		public string XAmznRequestId { get; set; } 

		/// <summary>
		/// Success.
		/// </summary>
		public SubmitFulfillmentOrderStatusUpdateResponse SubmitFulfillmentOrderStatusUpdateResponse { get; set; } 
	}
}
