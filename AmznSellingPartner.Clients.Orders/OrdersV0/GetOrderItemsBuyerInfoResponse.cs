namespace AmznSellingPartner.Clients.Orders.OrdersV0
{
	using Newtonsoft.Json;

	/// <summary>
	/// The response schema for the `getOrderItemsBuyerInfo` operation.
	/// </summary>
	public class GetOrderItemsBuyerInfoResponse : BaseClass
	{
		/// <summary>
		/// The payload for the `getOrderItemsBuyerInfo` operation.
		/// </summary>
		[JsonProperty("payload")]
		public OrderItemsBuyerInfoList Payload { get; set; }

		/// <summary>
		/// One or more unexpected errors occurred during the `getOrderItemsBuyerInfo` operation.
		/// </summary>
		[JsonProperty("errors")]
		public ErrorList Errors { get; set; }
	}
}
