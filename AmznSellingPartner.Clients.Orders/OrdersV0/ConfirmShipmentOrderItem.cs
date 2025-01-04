namespace AmznSellingPartner.Clients.Orders.OrdersV0
{
	using AmznSellingPartner.Clients.Attributes;

	using Newtonsoft.Json;

	/// <summary>
	/// A single order item.
	/// </summary>
	public class ConfirmShipmentOrderItem : BaseClass
	{
		/// <summary>
		/// The order item's unique identifier.
		/// </summary>
		[JsonProperty("orderItemId")]
		[IsRequired]
		public string OrderItemId { get; set; }

		/// <summary>
		/// The item's quantity.
		/// </summary>
		[JsonProperty("quantity")]
		[IsRequired]
		public int Quantity { get; set; }

		/// <summary>
		/// The list of transparency codes.
		/// </summary>
		[JsonProperty("transparencyCodes")]
		public TransparencyCodeList TransparencyCodes { get; set; }
	}
}
