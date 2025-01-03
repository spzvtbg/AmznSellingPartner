namespace AmznSellingPartner.Clients.FulfillmentOutbound.FulfillmentOutbound20200701
{
	using AmznSellingPartner.Clients.Attributes;

	using Newtonsoft.Json;

	/// <summary>
	/// Item information for a shipment in a fulfillment order.
	/// </summary>
	public class FulfillmentShipmentItem : BaseClass
	{
		/// <summary>
		/// The seller SKU of the item.
		/// </summary>
		[IsRequired]
		[JsonProperty("sellerSku")]
		public string SellerSku { get; set; }

		/// <summary>
		/// The fulfillment order item identifier that the seller created and submitted with a call to the `createFulfillm
		/// ntOrder` operation.
		/// </summary>
		[IsRequired]
		[JsonProperty("sellerFulfillmentOrderItemId")]
		public string SellerFulfillmentOrderItemId { get; set; }

		[IsRequired]
		[JsonProperty("quantity")]
		public Quantity Quantity { get; set; }

		/// <summary>
		/// An identifier for the package that contains the item quantity.
		/// </summary>
		[JsonProperty("packageNumber")]
		public int PackageNumber { get; set; }

		/// <summary>
		/// The serial number of the shipped item.
		/// </summary>
		[JsonProperty("serialNumber")]
		public string SerialNumber { get; set; }

		/// <summary>
		/// The manufacturer lot codes of the shipped items.
		/// </summary>
		[JsonProperty("manufacturerLotCodes")]
		public StringList ManufacturerLotCodes { get; set; }
	}
}
