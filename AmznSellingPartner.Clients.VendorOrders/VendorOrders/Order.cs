namespace AmznSellingPartner.Clients.VendorOrders.VendorOrders
{
	using AmznSellingPartner.Clients.Attributes;

	using Newtonsoft.Json;

	/// <summary>
	/// Represents an order placed by Amazon, including the purchase order number, current state, and order details
	/// </summary>
	public class Order : BaseClass
	{
		/// <summary>
		/// The purchase order number for this order
		/// Formatting Notes: 8-character alpha-numeric code
		/// </summary>
		[IsRequired]
		[JsonProperty("purchaseOrderNumber")]
		public string PurchaseOrderNumber { get; set; }

		/// <summary>
		/// This field will contain the current state of the purchase order
		/// </summary>
		[IsRequired]
		[JsonProperty("purchaseOrderState")]
		public PurchaseOrderState PurchaseOrderState { get; set; }

		/// <summary>
		/// Details of an order
		/// </summary>
		[JsonProperty("orderDetails")]
		public OrderDetails OrderDetails { get; set; }
	}
}
