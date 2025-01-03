namespace AmznSellingPartner.Clients.FulfillmentOutbound.FulfillmentOutbound20200701
{
	using AmznSellingPartner.Clients.Attributes;

	using Newtonsoft.Json;

	/// <summary>
	/// Information about unfulfillable items in a fulfillment order preview.
	/// </summary>
	public class UnfulfillablePreviewItem : BaseClass
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
		/// A fulfillment order item identifier created with a call to the `getFulfillmentPreview` operation.
		/// </summary>
		[IsRequired]
		[MaxLength(50)]
		[JsonProperty("sellerFulfillmentOrderItemId")]
		public string SellerFulfillmentOrderItemId { get; set; }

		/// <summary>
		/// Error codes associated with the fulfillment order preview that indicate why the item is unfulfillabl
		/// e.
		/// </summary>
		[JsonProperty("itemUnfulfillableReasons")]
		public StringList ItemUnfulfillableReasons { get; set; }
	}
}
