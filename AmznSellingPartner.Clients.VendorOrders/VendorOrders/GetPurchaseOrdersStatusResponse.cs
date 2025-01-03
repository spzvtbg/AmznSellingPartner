namespace AmznSellingPartner.Clients.VendorOrders.VendorOrders
{
	using Newtonsoft.Json;

	/// <summary>
	/// The response schema for the getPurchaseOrdersStatus operation.
	/// </summary>
	public class GetPurchaseOrdersStatusResponse : BaseClass
	{
		/// <summary>
		/// Current status of list of purchase orders.
		/// </summary>
		[JsonProperty("payload")]
		public OrderListStatus Payload { get; set; }

		[JsonProperty("errors")]
		public ErrorList Errors { get; set; }
	}
}
