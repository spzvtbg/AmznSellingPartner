namespace AmznSellingPartner.Clients.VendorOrders.VendorOrders
{
	using Newtonsoft.Json;

	/// <summary>
	/// The response schema for the getPurchaseOrder operation.
	/// </summary>
	public class GetPurchaseOrderResponse : BaseClass
	{
		/// <summary>
		/// The details of the requested order
		/// </summary>
		[JsonProperty("payload")]
		public Order Payload { get; set; }

		[JsonProperty("errors")]
		public ErrorList Errors { get; set; }
	}
}
