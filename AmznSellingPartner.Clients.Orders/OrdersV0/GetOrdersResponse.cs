namespace AmznSellingPartner.Clients.Orders.OrdersV0
{
	using Newtonsoft.Json;

	/// <summary>
	/// The response schema for the `getOrders` operation.
	/// </summary>
	public class GetOrdersResponse : BaseClass
	{
		/// <summary>
		/// The payload for the `getOrders` operation.
		/// </summary>
		[JsonProperty("payload")]
		public OrdersList Payload { get; set; } 

		/// <summary>
		/// One or more unexpected errors occurred during the `getOrders` operation.
		/// </summary>
		[JsonProperty("errors")]
		public ErrorList Errors { get; set; } 
	}
}
