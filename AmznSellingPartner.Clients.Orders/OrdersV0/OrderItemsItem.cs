namespace AmznSellingPartner.Clients.Orders.OrdersV0
{
	using Newtonsoft.Json;

	public class OrderItemsItem : BaseClass
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
