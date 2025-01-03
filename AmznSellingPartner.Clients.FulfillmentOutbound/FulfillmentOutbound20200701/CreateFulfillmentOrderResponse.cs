namespace AmznSellingPartner.Clients.FulfillmentOutbound.FulfillmentOutbound20200701
{
	using Newtonsoft.Json;

	/// <summary>
	/// The response schema for the `createFulfillmentOrder` operation.
	/// </summary>
	public class CreateFulfillmentOrderResponse : BaseClass
	{
		/// <summary>
		/// One or more unexpected errors occurred during the `createFulfillmentOrder` operation.
		/// </summary>
		[JsonProperty("errors")]
		public ErrorList Errors { get; set; }
	}
}
