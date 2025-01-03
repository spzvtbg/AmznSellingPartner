namespace AmznSellingPartner.Clients.VendorShipments.VendorShipments
{
	using AmznSellingPartner.Clients.Attributes;

	using Newtonsoft.Json;

	/// <summary>
	/// Details of the item being shipped
	/// </summary>
	public class PurchaseOrderItems : BaseClass
	{
		/// <summary>
		/// Item sequence number for the item
		/// The first item will be 001, the second 002, and so on
		/// This number is used as a reference to refer to this item from the carton or pallet level
		/// </summary>
		[IsRequired]
		[JsonProperty("itemSequenceNumber")]
		public string ItemSequenceNumber { get; set; }

		/// <summary>
		/// Amazon Standard Identification Number (ASIN) for a SKU
		/// </summary>
		[JsonProperty("buyerProductIdentifier")]
		public string BuyerProductIdentifier { get; set; }

		/// <summary>
		/// The vendor selected product identification of the item
		/// Should be the same as was sent in the purchase order
		/// </summary>
		[JsonProperty("vendorProductIdentifier")]
		public string VendorProductIdentifier { get; set; }

		/// <summary>
		/// Total item quantity shipped in this shipment
		/// </summary>
		[IsRequired]
		[JsonProperty("shippedQuantity")]
		public ItemQuantity ShippedQuantity { get; set; }

		[JsonProperty("maximumRetailPrice")]
		public Money MaximumRetailPrice { get; set; }
	}
}
