namespace AmznSellingPartner.Clients.VendorOrders.VendorOrders
{
	using Newtonsoft.Json;

	using System.Collections.Generic;

	/// <summary>
	/// A list of order statuses.
	/// </summary>
	public class OrderListStatus : BaseClass
	{
		[JsonProperty("pagination")]
		public Pagination Pagination { get; set; }

		/// <summary>
		/// Represents an order status within the OrderListStatus.
		/// </summary>
		[JsonProperty("ordersStatus")]
		public List<OrderStatus> OrdersStatus { get; set; }
	}
}
