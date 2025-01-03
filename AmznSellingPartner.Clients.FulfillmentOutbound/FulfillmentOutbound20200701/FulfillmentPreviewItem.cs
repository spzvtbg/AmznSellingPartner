namespace AmznSellingPartner.Clients.FulfillmentOutbound.FulfillmentOutbound20200701
{
	using AmznSellingPartner.Clients.Attributes;

	using Newtonsoft.Json;

	/// <summary>
	/// Item information for a shipment in a fulfillment order preview
	/// </summary>
	public class FulfillmentPreviewItem : BaseClass
	{
		/// <summary>
		/// The seller SKU of the item
		/// </summary>
		[IsRequired]
		[JsonProperty("sellerSku")]
		public string SellerSku { get; set; }

		/// <summary>
		/// The item quantity
		/// </summary>
		[IsRequired]
		[JsonProperty("quantity")]
		public Quantity Quantity { get; set; }

		/// <summary>
		/// A fulfillment order item identifier that the seller created with a call to the `createFulfillmentOrder` operat
		/// on
		/// </summary>
		[IsRequired]
		[JsonProperty("sellerFulfillmentOrderItemId")]
		public string SellerFulfillmentOrderItemId { get; set; }

		/// <summary>
		/// The estimated shipping weight of the item quantity for a single item, as identified by `sellerSku`, in a shipm
		/// nt
		/// </summary>
		[JsonProperty("estimatedShippingWeight")]
		public Weight EstimatedShippingWeight { get; set; }

		/// <summary>
		/// The method used to calculate the estimated shipping weight
		/// </summary>
		[JsonProperty("shippingWeightCalculationMethod")]
		public ShippingWeightCalculationMethod ShippingWeightCalculationMethod { get; set; }
	}
}
