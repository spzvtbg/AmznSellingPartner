namespace AmznSellingPartner.Clients.Orders.OrdersV0
{
	using AmznSellingPartner.Clients.Attributes;

	using Newtonsoft.Json;

	/// <summary>
	/// A single order item
	/// </summary>
	public class ConfirmShipmentOrderItem : BaseClass
	{
		/// <summary>
		/// The order item's unique identifier
		/// </summary>
		[IsRequired]
		[JsonProperty("orderItemId")]
		public string OrderItemId { get; set; }

		/// <summary>
		/// The item's quantity
		/// </summary>
		[IsRequired]
		[JsonProperty("quantity")]
		public int Quantity { get; set; }

		/// <summary>
		/// The list of transparency codes
		/// </summary>
		[JsonProperty("transparencyCodes")]
		public TransparencyCodeList TransparencyCodes { get; set; }
	}
}
