namespace AmznSellingPartner.Clients.Orders.OrdersV0
{
	using Newtonsoft.Json;

	/// <summary>
	/// The response schema for the `getOrderRegulatedInfo` operation.
	/// </summary>
	public class GetOrderRegulatedInfoResponse : BaseClass
	{
		/// <summary>
		/// The payload for the `getOrderRegulatedInfo` operation.
		/// </summary>
		[JsonProperty("payload")]
		public OrderRegulatedInfo Payload { get; set; } 

		/// <summary>
		/// One or more unexpected errors occurred during the `getOrderRegulatedInfo` operation.
		/// </summary>
		[JsonProperty("errors")]
		public ErrorList Errors { get; set; } 
	}
}
