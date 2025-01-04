namespace AmznSellingPartner.Clients.FulfillmentOutbound.FulfillmentOutbound20200701
{
	using Newtonsoft.Json;

	/// <summary>
	/// The response schema for the `updateFulfillmentOrder` operation.
	/// </summary>
	public class UpdateFulfillmentOrderResponse : BaseClass
	{
		/// <summary>
		/// One or more unexpected errors occurred during the `updateFulfillmentOrder` operation.
		/// </summary>
		[JsonProperty("errors")]
		public ErrorList Errors { get; set; } 
	}
}
