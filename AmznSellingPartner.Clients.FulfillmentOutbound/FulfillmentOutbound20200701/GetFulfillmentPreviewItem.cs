namespace AmznSellingPartner.Clients.FulfillmentOutbound.FulfillmentOutbound20200701
{
	using AmznSellingPartner.Clients.Attributes;

	using Newtonsoft.Json;

	/// <summary>
	/// Item information for a fulfillment order preview.
	/// </summary>
	public class GetFulfillmentPreviewItem : BaseClass
	{
		/// <summary>
		/// The seller SKU of the item.
		/// </summary>
		[IsRequired]
		[MaxLength(50)]
		[JsonProperty("sellerSku")]
		public string SellerSku { get; set; }

		[IsRequired]
		[JsonProperty("quantity")]
		public Quantity Quantity { get; set; }

		/// <summary>
		/// The monetary value assigned by the seller to this item. This is a required field if this order is an export or
		/// er or an India MCF order.
		/// </summary>
		[JsonProperty("perUnitDeclaredValue")]
		public Money PerUnitDeclaredValue { get; set; }

		/// <summary>
		/// A fulfillment order item identifier that the seller creates to track items in the fulfillment preview.
		/// </summary>
		[IsRequired]
		[MaxLength(50)]
		[JsonProperty("sellerFulfillmentOrderItemId")]
		public string SellerFulfillmentOrderItemId { get; set; }
	}
}
