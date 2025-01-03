namespace AmznSellingPartner.Clients.FulfillmentOutbound.FulfillmentOutbound20200701
{
	using Newtonsoft.Json;

	/// <summary>
	/// The response schema for the `SubmitFulfillmentOrderStatusUpdate` operation.
	/// </summary>
	public class SubmitFulfillmentOrderStatusUpdateResponse : BaseClass
	{
		/// <summary>
		/// One or more unexpected errors occurred during the `SubmitFulfillmentOrderStatusUpdate` operation.
		/// </summary>
		[JsonProperty("errors")]
		public ErrorList Errors { get; set; }
	}
}
