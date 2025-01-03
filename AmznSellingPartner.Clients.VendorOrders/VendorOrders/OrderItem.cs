namespace AmznSellingPartner.Clients.VendorOrders.VendorOrders
{
	using AmznSellingPartner.Clients.Attributes;

	using Newtonsoft.Json;

	/// <summary>
	/// Represents an individual item in an order, including item details, quantities, pricing, and backorder informat
	/// on.
	/// </summary>
	public class OrderItem : BaseClass
	{
		/// <summary>
		/// Numbering of the item on the purchase order. The first item will be 1, the second 2, and so on.
		/// </summary>
		[IsRequired]
		[JsonProperty("itemSequenceNumber")]
		public string ItemSequenceNumber { get; set; }

		/// <summary>
		/// Amazon Standard Identification Number (ASIN) of an item.
		/// </summary>
		[JsonProperty("amazonProductIdentifier")]
		public string AmazonProductIdentifier { get; set; }

		/// <summary>
		/// The vendor selected product identification of the item.
		/// </summary>
		[JsonProperty("vendorProductIdentifier")]
		public string VendorProductIdentifier { get; set; }

		/// <summary>
		/// Item quantity ordered.
		/// </summary>
		[IsRequired]
		[JsonProperty("orderedQuantity")]
		public ItemQuantity OrderedQuantity { get; set; }

		/// <summary>
		/// When true, we will accept backorder confirmations for this item.
		/// </summary>
		[IsRequired]
		[JsonProperty("isBackOrderAllowed")]
		public bool IsBackOrderAllowed { get; set; }

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
	}
}
