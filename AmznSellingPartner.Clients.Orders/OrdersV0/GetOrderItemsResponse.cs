namespace AmznSellingPartner.Clients.Orders.OrdersV0
{
	using Newtonsoft.Json;

	/// <summary>
	/// The response schema for the `getOrderItems` operation
	/// </summary>
	public class GetOrderItemsResponse : BaseClass
	{
		/// <summary>
		/// The payload for the `getOrderItems` operation
		/// </summary>
		[JsonProperty("payload")]
		public OrderItemsList Payload { get; set; }

		/// <summary>
		/// One or more unexpected errors occurred during the `getOrderItems` operation
		/// </summary>
		[JsonProperty("errors")]
		public ErrorList Errors { get; set; }
	}
}
