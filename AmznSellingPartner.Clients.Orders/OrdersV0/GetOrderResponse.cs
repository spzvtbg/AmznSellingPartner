namespace AmznSellingPartner.Clients.Orders.OrdersV0
{
	using Newtonsoft.Json;

	/// <summary>
	/// The response schema for the `getOrder` operation.
	/// </summary>
	public class GetOrderResponse : BaseClass
	{
		/// <summary>
		/// The payload for the `getOrder` operation.
		/// </summary>
		[JsonProperty("payload")]
		public Order Payload { get; set; } 

		/// <summary>
		/// One or more unexpected errors occurred during the `getOrder` operation.
		/// </summary>
		[JsonProperty("errors")]
		public ErrorList Errors { get; set; } 
	}
}
