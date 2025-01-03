namespace AmznSellingPartner.Clients.FulfillmentOutbound.FulfillmentOutbound20200701
{
	using Newtonsoft.Json;

	/// <summary>
	/// The request body schema for the `submitFulfillmentOrderStatusUpdate` operation.
	/// </summary>
	public class SubmitFulfillmentOrderStatusUpdateRequest : BaseClass
	{
		[JsonProperty("fulfillmentOrderStatus")]
		public FulfillmentOrderStatus FulfillmentOrderStatus { get; set; }
	}
}
