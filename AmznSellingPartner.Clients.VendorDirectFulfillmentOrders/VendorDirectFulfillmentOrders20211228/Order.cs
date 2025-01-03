namespace AmznSellingPartner.Clients.VendorDirectFulfillmentOrders.VendorDirectFulfillmentOrders20211228
{
	using AmznSellingPartner.Clients.Attributes;

	using Newtonsoft.Json;

	/// <summary>
	/// Represents a purchase order.
	/// </summary>
	public class Order : BaseClass
	{
		/// <summary>
		/// The purchase order number for this order. Formatting Notes: alpha-numeric code.
		/// </summary>
		[IsRequired]
		[JsonProperty("purchaseOrderNumber")]
		public string PurchaseOrderNumber { get; set; }

		/// <summary>
		/// Purchase order details.
		/// </summary>
		[JsonProperty("orderDetails")]
		public OrderDetails OrderDetails { get; set; }
	}
}
