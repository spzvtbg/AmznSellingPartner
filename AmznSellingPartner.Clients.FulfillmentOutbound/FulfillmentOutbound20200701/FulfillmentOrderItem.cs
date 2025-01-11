namespace AmznSellingPartner.Clients.FulfillmentOutbound.FulfillmentOutbound20200701
{
	using AmznSellingPartner.Clients.Attributes;

	using Newtonsoft.Json;

	/// <summary>
	/// Item information for a fulfillment order.
	/// </summary>
	public class FulfillmentOrderItem : BaseClass
	{
		/// <summary>
		/// The seller SKU of the item.
		/// </summary>
		[JsonProperty("sellerSku")]
		[IsRequired]
		public string SellerSku { get; set; } 

		/// <summary>
		/// A fulfillment order item identifier submitted with a call to the `createFulfillmentOrder`
		/// operation.
		/// </summary>
		[JsonProperty("sellerFulfillmentOrderItemId")]
		[IsRequired]
		public string SellerFulfillmentOrderItemId { get; set; } 

		[JsonProperty("quantity")]
		[IsRequired]
		public Quantity Quantity { get; set; } 

		/// <summary>
		/// A message to the gift recipient, if applicable.
		/// </summary>
		[JsonProperty("giftMessage")]
		public string GiftMessage { get; set; } 

		/// <summary>
		/// Item-specific text that displays in recipient-facing materials such as the outbound shipment
		/// packing slip.
		/// </summary>
		[JsonProperty("displayableComment")]
		public string DisplayableComment { get; set; } 

		/// <summary>
		/// Amazon's fulfillment network SKU of the item.
		/// </summary>
		[JsonProperty("fulfillmentNetworkSku")]
		public string FulfillmentNetworkSku { get; set; } 

		/// <summary>
		/// Indicates whether the item is sellable or unsellable.
		/// </summary>
		[JsonProperty("orderItemDisposition")]
		public string OrderItemDisposition { get; set; } 

		/// <summary>
		/// The item quantity that was cancelled by the seller.
		/// </summary>
		[JsonProperty("cancelledQuantity")]
		[IsRequired]
		public Quantity CancelledQuantity { get; set; } 

		/// <summary>
		/// The item quantity that is unfulfillable.
		/// </summary>
		[JsonProperty("unfulfillableQuantity")]
		[IsRequired]
		public Quantity UnfulfillableQuantity { get; set; } 

		/// <summary>
		/// The estimated date and time that the item quantity is scheduled to ship from the fulfillment
		/// center. Note that this value can change over time. If the shipment that contains the item quantity
		/// has been cancelled, `estimatedShipDate` is not returned.
		/// </summary>
		[JsonProperty("estimatedShipDate")]
		public Timestamp EstimatedShipDate { get; set; } 

		/// <summary>
		/// The estimated arrival date and time of the item quantity. Note that this value can change over
		/// time. If the shipment that contains the item quantity has been cancelled, `estimatedArrivalDate`
		/// is not returned.
		/// </summary>
		[JsonProperty("estimatedArrivalDate")]
		public Timestamp EstimatedArrivalDate { get; set; } 

		/// <summary>
		/// The amount to be collected from the recipient for this item in a COD (Cash On Delivery) or
		/// der.
		/// </summary>
		[JsonProperty("perUnitPrice")]
		public Money PerUnitPrice { get; set; } 

		/// <summary>
		/// The tax on the amount to be collected from the recipient for this item in a COD (Cash On Delivery)
		/// order.
		/// </summary>
		[JsonProperty("perUnitTax")]
		public Money PerUnitTax { get; set; } 

		/// <summary>
		/// The monetary value assigned by the seller to this item. This is a required field for India
		/// MCF orders.
		/// </summary>
		[JsonProperty("perUnitDeclaredValue")]
		public Money PerUnitDeclaredValue { get; set; } 
	}
}
