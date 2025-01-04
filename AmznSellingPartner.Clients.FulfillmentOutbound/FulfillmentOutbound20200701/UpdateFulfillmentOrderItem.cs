namespace AmznSellingPartner.Clients.FulfillmentOutbound.FulfillmentOutbound20200701
{
	using AmznSellingPartner.Clients.Attributes;

	using Newtonsoft.Json;

	/// <summary>
	/// Item information for updating a fulfillment order.
	/// </summary>
	public class UpdateFulfillmentOrderItem : BaseClass
	{
		/// <summary>
		/// The seller SKU of the item.
		/// </summary>
		[JsonProperty("sellerSku")]
		public string SellerSku { get; set; }

		/// <summary>
		/// Identifies the fulfillment order item to update. Created with a previous call to the `createFulfillmentOrder`
		/// operation.
		/// </summary>
		[JsonProperty("sellerFulfillmentOrderItemId")]
		[IsRequired]
		[MaxLength(50)]
		public string SellerFulfillmentOrderItemId { get; set; }

		[JsonProperty("quantity")]
		[IsRequired]
		public Quantity Quantity { get; set; }

		/// <summary>
		/// A message to the gift recipient, if applicable.
		/// </summary>
		[JsonProperty("giftMessage")]
		[MaxLength(512)]
		public string GiftMessage { get; set; }

		/// <summary>
		/// Item-specific text that displays in recipient-facing materials such as the outbound shipment packing
		/// slip.
		/// </summary>
		[JsonProperty("displayableComment")]
		[MaxLength(250)]
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
		/// The monetary value assigned by the seller to this item. This is a required field for India MCF order
		/// s.
		/// </summary>
		[JsonProperty("perUnitDeclaredValue")]
		public Money PerUnitDeclaredValue { get; set; }

		/// <summary>
		/// The amount to be collected from the recipient for this item in a COD (Cash On Delivery) order.
		/// </summary>
		[JsonProperty("perUnitPrice")]
		public Money PerUnitPrice { get; set; }

		/// <summary>
		/// The tax on the amount to be collected from the recipient for this item in a COD (Cash On Delivery) o
		/// rder.
		/// </summary>
		[JsonProperty("perUnitTax")]
		public Money PerUnitTax { get; set; }
	}
}
