namespace AmznSellingPartner.Clients.FulfillmentOutbound.FulfillmentOutbound20200701
{
	using Newtonsoft.Json;

	public class SubmitFulfillmentOrderStatusUpdatePutResponse : BaseHttpResponse<SubmitFulfillmentOrderStatusUpdatePutResponse>
	{
		/// <summary>
		/// Unique request reference identifier.
		/// </summary>
		[JsonProperty("x-amzn-requestid")]
		public string XAmznRequestid { get; set; } 

		/// <summary>
		/// Success.
		/// </summary>
		public SubmitFulfillmentOrderStatusUpdateResponse SubmitFulfillmentOrderStatusUpdateResponse { get; set; } 
	}
}
