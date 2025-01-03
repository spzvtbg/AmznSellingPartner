namespace AmznSellingPartner.Clients.Orders.OrdersV0
{
	using Newtonsoft.Json;

	/// <summary>
	/// The response schema for the `getOrderBuyerInfo` operation
	/// </summary>
	public class GetOrderBuyerInfoResponse : BaseClass
	{
		/// <summary>
		/// The payload for the `getOrderBuyerInfo` operation
		/// </summary>
		[JsonProperty("payload")]
		public OrderBuyerInfo Payload { get; set; }

		/// <summary>
		/// One or more unexpected errors occurred during the `getOrderBuyerInfo` operation
		/// </summary>
		[JsonProperty("errors")]
		public ErrorList Errors { get; set; }
	}
}
