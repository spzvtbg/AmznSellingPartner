namespace AmznSellingPartner.Clients.FulfillmentOutbound.FulfillmentOutbound20200701
{
	using Newtonsoft.Json;

	/// <summary>
	/// The response schema for the `getFulfillmentOrder` operation.
	/// </summary>
	public class GetFulfillmentOrderResponse : BaseClass
	{
		/// <summary>
		/// The payload for the `getFulfillmentOrder` operation.
		/// </summary>
		[JsonProperty("payload")]
		public GetFulfillmentOrderResult Payload { get; set; } 

		/// <summary>
		/// One or more unexpected errors occurred during the `getFulfillmentOrder` operation.
		/// </summary>
		[JsonProperty("errors")]
		public ErrorList Errors { get; set; } 
	}
}
