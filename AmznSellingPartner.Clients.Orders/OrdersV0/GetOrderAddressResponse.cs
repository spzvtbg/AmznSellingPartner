namespace AmznSellingPartner.Clients.Orders.OrdersV0
{
	using Newtonsoft.Json;

	/// <summary>
	/// The response schema for the `getOrderAddress` operation.
	/// </summary>
	public class GetOrderAddressResponse : BaseClass
	{
		/// <summary>
		/// The payload for the `getOrderAddress` operations.
		/// </summary>
		[JsonProperty("payload")]
		public OrderAddress Payload { get; set; } 

		/// <summary>
		/// One or more unexpected errors occurred during the `getOrderAddress` operation.
		/// </summary>
		[JsonProperty("errors")]
		public ErrorList Errors { get; set; } 
	}
}
