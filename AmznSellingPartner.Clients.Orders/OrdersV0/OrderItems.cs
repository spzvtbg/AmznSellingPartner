namespace AmznSellingPartner.Clients.Orders.OrdersV0
{
	using Newtonsoft.Json;

	using System.Collections.Generic;

	/// <summary>
	/// For partial shipment status updates, the list of order items and quantities to be updated.
	/// </summary>
	public class OrderItems : List<OrderItems>
	{
		/// <summary>
		/// The order item's unique identifier.
		/// </summary>
		[JsonProperty("orderItemId")]
		public string OrderItemId { get; set; }

		/// <summary>
		/// The quantity for which to update the shipment status.
		/// </summary>
		[JsonProperty("quantity")]
		public int Quantity { get; set; }
	}
}
