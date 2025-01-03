namespace AmznSellingPartner.Clients.Orders.OrdersV0
{
	using Newtonsoft.Json;

	/// <summary>
	/// An item that is associated with an order item. For example, a tire installation service that is purchased
	/// with tires.
	/// </summary>
	public class AssociatedItem : BaseClass
	{
		/// <summary>
		/// The order item's order identifier, in 3-7-7 format.
		/// </summary>
		[JsonProperty("OrderId")]
		public string OrderId { get; set; }

		/// <summary>
		/// An Amazon-defined item identifier for the associated item.
		/// </summary>
		[JsonProperty("OrderItemId")]
		public string OrderItemId { get; set; }

		[JsonProperty("AssociationType")]
		public AssociationType AssociationType { get; set; }
	}
}
