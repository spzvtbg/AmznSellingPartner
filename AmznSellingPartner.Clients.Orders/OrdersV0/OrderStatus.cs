namespace AmznSellingPartner.Clients.Orders.OrdersV0
{
	using Newtonsoft.Json;
	using Newtonsoft.Json.Converters;

	using System.Runtime.Serialization;

	[JsonConverter(typeof(StringEnumConverter))]
	public enum OrderStatus
	{
		/// <summary>
		/// The order has been placed but payment has not been authorized. The order is not ready for shipment. Note
		/// that for orders with `OrderType = Standard`, the initial order status is Pending. For orders with `OrderType
		/// = Preorder`, the initial order status is `PendingAvailability`, and the order passes into the Pending
		/// status when the payment authorization process begins.
		/// </summary>
		[EnumMember(Value = "Pending")]
		Pending,

		/// <summary>
		/// Payment has been authorized and order is ready for shipment, but no items in the order have been shi
		/// pped.
		/// </summary>
		[EnumMember(Value = "Unshipped")]
		Unshipped,

		/// <summary>
		/// One or more (but not all) items in the order have been shipped.
		/// </summary>
		[EnumMember(Value = "PartiallyShipped")]
		PartiallyShipped,

		/// <summary>
		/// All items in the order have been shipped.
		/// </summary>
		[EnumMember(Value = "Shipped")]
		Shipped,

		/// <summary>
		/// The order was canceled.
		/// </summary>
		[EnumMember(Value = "Canceled")]
		Canceled,

		/// <summary>
		/// The order cannot be fulfilled. This state applies only to Amazon-fulfilled orders that were not placed
		/// on Amazon's retail web site.
		/// </summary>
		[EnumMember(Value = "Unfulfillable")]
		Unfulfillable,

		/// <summary>
		/// All items in the order have been shipped. The seller has not yet given confirmation to Amazon that the
		/// invoice has been shipped to the buyer.
		/// </summary>
		[EnumMember(Value = "InvoiceUnconfirmed")]
		InvoiceUnconfirmed,

		/// <summary>
		/// This status is available for pre-orders only. The order has been placed, payment has not been authorized,
		/// and the release date for the item is in the future. The order is not ready for shipment.
		/// </summary>
		[EnumMember(Value = "PendingAvailability")]
		PendingAvailability,
	}
}
