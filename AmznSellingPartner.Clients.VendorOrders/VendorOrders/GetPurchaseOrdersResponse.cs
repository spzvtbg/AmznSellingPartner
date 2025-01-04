namespace AmznSellingPartner.Clients.VendorOrders.VendorOrders
{
	using Newtonsoft.Json;

	/// <summary>
	/// The response schema for the getPurchaseOrders operation.
	/// </summary>
	public class GetPurchaseOrdersResponse : BaseClass
	{
		/// <summary>
		/// A list of orders.
		/// </summary>
		[JsonProperty("payload")]
		public OrderList Payload { get; set; } 

		[JsonProperty("errors")]
		public ErrorList Errors { get; set; } 
	}
}
