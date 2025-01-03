namespace AmznSellingPartner.Clients.VendorDirectFulfillmentShipping.VendorDirectFulfillmentShipping20211228
{
	using AmznSellingPartner.Clients.Attributes;

	using Newtonsoft.Json;

	/// <summary>
	/// An item that has been packed into a container for shipping.
	/// </summary>
	public class PackedItem : BaseClass
	{
		/// <summary>
		/// The sequence number of the item. The number must be the same as the order number of the item.
		/// </summary>
		[IsRequired]
		[JsonProperty("itemSequenceNumber")]
		public int ItemSequenceNumber { get; set; }

		/// <summary>
		/// The buyer's Amazon Standard Identification Number (ASIN) of an item. Either `buyerProductIdentifier` or `vendo
		/// ProductIdentifier` is required.
		/// </summary>
		[JsonProperty("buyerProductIdentifier")]
		public string BuyerProductIdentifier { get; set; }

		/// <summary>
		/// The piece number of the item in this container. This is required when the item is split across different conta
		/// ners.
		/// </summary>
		[JsonProperty("pieceNumber")]
		public int PieceNumber { get; set; }

		/// <summary>
		/// An item's product identifier, which the vendor selects. This identifier should be the same as the identifier,
		/// uch as a SKU, in the purchase order.
		/// </summary>
		[JsonProperty("vendorProductIdentifier")]
		public string VendorProductIdentifier { get; set; }

		/// <summary>
		/// The total quantity of items that are packed in the shipment.
		/// </summary>
		[IsRequired]
		[JsonProperty("packedQuantity")]
		public ItemQuantity PackedQuantity { get; set; }
	}
}
