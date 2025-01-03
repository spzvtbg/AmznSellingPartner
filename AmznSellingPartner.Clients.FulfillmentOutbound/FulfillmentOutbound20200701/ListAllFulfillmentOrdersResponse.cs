namespace AmznSellingPartner.Clients.FulfillmentOutbound.FulfillmentOutbound20200701
{
	using Newtonsoft.Json;

	/// <summary>
	/// The response schema for the `listAllFulfillmentOrders` operation
	/// </summary>
	public class ListAllFulfillmentOrdersResponse : BaseClass
	{
		/// <summary>
		/// The payload for the `listAllFulfillmentOrders` operation
		/// </summary>
		[JsonProperty("payload")]
		public ListAllFulfillmentOrdersResult Payload { get; set; }

		/// <summary>
		/// One or more unexpected errors occurred during the `listAllFulfillmentOrders` operation
		/// </summary>
		[JsonProperty("errors")]
		public ErrorList Errors { get; set; }
	}
}
