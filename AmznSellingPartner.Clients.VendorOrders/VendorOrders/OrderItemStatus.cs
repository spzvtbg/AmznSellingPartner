namespace AmznSellingPartner.Clients.VendorOrders.VendorOrders
{
	using AmznSellingPartner.Clients.Attributes;

	using Newtonsoft.Json;

	/// <summary>
	/// Represents the current status of an order item, including acknowledgement and receiving details.
	/// </summary>
	public class OrderItemStatus : BaseClass
	{
		/// <summary>
		/// Numbering of the item on the purchase order. The first item will be 1, the second 2, and so on.
		/// </summary>
		[JsonProperty("itemSequenceNumber")]
		[IsRequired]
		public string ItemSequenceNumber { get; set; }

		/// <summary>
		/// Buyer's Standard Identification Number (ASIN) of an item.
		/// </summary>
		[JsonProperty("buyerProductIdentifier")]
		public string BuyerProductIdentifier { get; set; }

		/// <summary>
		/// The vendor selected product identification of the item.
		/// </summary>
		[JsonProperty("vendorProductIdentifier")]
		public string VendorProductIdentifier { get; set; }

		/// <summary>
		/// The net cost of an item per each or weight unit.
		/// </summary>
		[JsonProperty("netCost")]
		public Money NetCost { get; set; }

		/// <summary>
		/// The list price of an item per each or weight unit.
		/// </summary>
		[JsonProperty("listPrice")]
		public Money ListPrice { get; set; }

		/// <summary>
		/// Ordered quantity information.
		/// </summary>
		[JsonProperty("orderedQuantity")]
		public OrderedQuantity OrderedQuantity { get; set; }

		/// <summary>
		/// Acknowledgement status information.
		/// </summary>
		[JsonProperty("acknowledgementStatus")]
		public AcknowledgementStatus AcknowledgementStatus { get; set; }

		/// <summary>
		/// Item receive status at the buyer's warehouse.
		/// </summary>
		[JsonProperty("receivingStatus")]
		public ReceivingStatus ReceivingStatus { get; set; }
	}
}
