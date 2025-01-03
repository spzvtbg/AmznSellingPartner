namespace AmznSellingPartner.Clients.VendorDirectFulfillmentOrders.VendorDirectFulfillmentOrders20211228
{
	using AmznSellingPartner.Clients.Attributes;

	using Newtonsoft.Json;

	/// <summary>
	/// Details of an individual item within the order being acknowledged.
	/// </summary>
	public class OrderItemAcknowledgement : BaseClass
	{
		/// <summary>
		/// Line item sequence number for the item.
		/// </summary>
		[IsRequired]
		[JsonProperty("itemSequenceNumber")]
		public string ItemSequenceNumber { get; set; }

		/// <summary>
		/// Buyer's standard identification number (ASIN) of an item.
		/// </summary>
		[JsonProperty("buyerProductIdentifier")]
		public string BuyerProductIdentifier { get; set; }

		/// <summary>
		/// The vendor selected product identification of the item. Should be the same as was provided in the purchase
		/// order.
		/// </summary>
		[JsonProperty("vendorProductIdentifier")]
		public string VendorProductIdentifier { get; set; }

		/// <summary>
		/// Details of quantity acknowledged with the above acknowledgement code.
		/// </summary>
		[IsRequired]
		[JsonProperty("acknowledgedQuantity")]
		public ItemQuantity AcknowledgedQuantity { get; set; }
	}
}
