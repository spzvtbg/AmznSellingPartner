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
		[JsonProperty("sellerSku")]
		[IsRequired]
		[MaxLength(50)]
		public string SellerSku { get; set; } 

		[JsonProperty("quantity")]
		[IsRequired]
		public Quantity Quantity { get; set; } 

		/// <summary>
		/// The monetary value assigned by the seller to this item. This is a required field if this order
		/// is an export order or an India MCF order.
		/// </summary>
		[JsonProperty("perUnitDeclaredValue")]
		public Money PerUnitDeclaredValue { get; set; } 

		/// <summary>
		/// A fulfillment order item identifier that the seller creates to track items in the fulfillment
		/// preview.
		/// </summary>
		[JsonProperty("sellerFulfillmentOrderItemId")]
		[IsRequired]
		[MaxLength(50)]
		public string SellerFulfillmentOrderItemId { get; set; } 
	}
}
