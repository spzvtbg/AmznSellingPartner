namespace AmznSellingPartner.Clients.FulfillmentOutbound.FulfillmentOutbound20200701
{
	using Newtonsoft.Json;

	/// <summary>
	/// The response schema for the `cancelFulfillmentOrder` operation.
	/// </summary>
	public class CancelFulfillmentOrderResponse : BaseClass
	{
		/// <summary>
		/// One or more unexpected errors occurred during the `cancelFulfillmentOrder` operation.
		/// </summary>
		[JsonProperty("errors")]
		public ErrorList Errors { get; set; }
	}
}
