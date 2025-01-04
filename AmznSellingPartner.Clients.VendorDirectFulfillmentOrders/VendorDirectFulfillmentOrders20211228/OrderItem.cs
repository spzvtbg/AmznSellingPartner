namespace AmznSellingPartner.Clients.VendorDirectFulfillmentOrders.VendorDirectFulfillmentOrders20211228
{
	using AmznSellingPartner.Clients.Attributes;

	using Newtonsoft.Json;

	/// <summary>
	/// An item within an order
	/// </summary>
	public class OrderItem : BaseClass
	{
		/// <summary>
		/// Numbering of the item on the purchase order. The first item will be 1, the second 2, and so on.
		/// </summary>
		[JsonProperty("itemSequenceNumber")]
		[IsRequired]
		public string ItemSequenceNumber { get; set; }

		/// <summary>
		/// Buyer's standard identification number (ASIN) of an item.
		/// </summary>
		[JsonProperty("buyerProductIdentifier")]
		public string BuyerProductIdentifier { get; set; }

		/// <summary>
		/// The vendor selected product identification of the item.
		/// </summary>
		[JsonProperty("vendorProductIdentifier")]
		public string VendorProductIdentifier { get; set; }

		/// <summary>
		/// Title for the item.
		/// </summary>
		[JsonProperty("title")]
		public string Title { get; set; }

		/// <summary>
		/// Item quantity ordered.
		/// </summary>
		[JsonProperty("orderedQuantity")]
		[IsRequired]
		public ItemQuantity OrderedQuantity { get; set; }

		/// <summary>
		/// Details for the scheduled delivery shipment.
		/// </summary>
		[JsonProperty("scheduledDeliveryShipment")]
		public ScheduledDeliveryShipment ScheduledDeliveryShipment { get; set; }

		/// <summary>
		/// Gift message and wrapId details.
		/// </summary>
		[JsonProperty("giftDetails")]
		public GiftDetails GiftDetails { get; set; }

		/// <summary>
		/// Net price (before tax) to vendor with currency details.
		/// </summary>
		[JsonProperty("netPrice")]
		[IsRequired]
		public Money NetPrice { get; set; }

		/// <summary>
		/// Total tax details for the line item.
		/// </summary>
		[JsonProperty("taxDetails")]
		public TaxItemDetails TaxDetails { get; set; }

		/// <summary>
		/// The price to Amazon each (cost).
		/// </summary>
		[JsonProperty("totalPrice")]
		public Money TotalPrice { get; set; }

		/// <summary>
		/// The buyer information for products the vendor has configured as customizable, specifying the types of
		/// customizations or configurations along with types and ranges for their product. This provides the ability
		/// for buyers to customize multiple aspects of the products according to what the vendor allows.
		/// </summary>
		[JsonProperty("buyerCustomizedInfo")]
		public BuyerCustomizedInfoDetail BuyerCustomizedInfo { get; set; }
	}
}
