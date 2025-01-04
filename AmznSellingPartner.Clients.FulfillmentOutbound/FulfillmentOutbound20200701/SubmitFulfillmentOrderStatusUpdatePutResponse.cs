namespace AmznSellingPartner.Clients.FulfillmentOutbound.FulfillmentOutbound20200701
{
	using AmznSellingPartner.Clients.Attributes;

	public class SubmitFulfillmentOrderStatusUpdatePutResponse : BaseHttpResponse<SubmitFulfillmentOrderStatusUpdatePutResponse>
	{
		/// <summary>
		/// Unique request reference identifier.
		/// </summary>
		[FromHeader("x-amzn-RequestId")]
		public string XAmznRequestId { get; set; }

		public bool Succeeded { get; set; }

		/// <summary>
		/// Success.
		/// </summary>
		public SubmitFulfillmentOrderStatusUpdateResponse SubmitFulfillmentOrderStatusUpdateResponse { get; set; }
	}
}
