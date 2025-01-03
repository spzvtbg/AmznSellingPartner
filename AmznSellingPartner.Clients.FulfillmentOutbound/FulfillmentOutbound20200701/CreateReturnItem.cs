namespace AmznSellingPartner.Clients.FulfillmentOutbound.FulfillmentOutbound20200701
{
	using AmznSellingPartner.Clients.Attributes;

	using Newtonsoft.Json;

	/// <summary>
	/// An item that Amazon accepted for return.
	/// </summary>
	public class CreateReturnItem : BaseClass
	{
		/// <summary>
		/// An identifier assigned by the seller to the return item.
		/// </summary>
		[IsRequired]
		[MaxLength(80)]
		[JsonProperty("sellerReturnItemId")]
		public string SellerReturnItemId { get; set; }

		/// <summary>
		/// The identifier assigned to the item by the seller when the fulfillment order was created.
		/// </summary>
		[IsRequired]
		[JsonProperty("sellerFulfillmentOrderItemId")]
		public string SellerFulfillmentOrderItemId { get; set; }

		/// <summary>
		/// The identifier for the shipment that is associated with the return item.
		/// </summary>
		[IsRequired]
		[JsonProperty("amazonShipmentId")]
		public string AmazonShipmentId { get; set; }

		/// <summary>
		/// The return reason code assigned to the return item by the seller.
		/// </summary>
		[IsRequired]
		[JsonProperty("returnReasonCode")]
		public string ReturnReasonCode { get; set; }

		/// <summary>
		/// An optional comment about the return item.
		/// </summary>
		[MaxLength(1000)]
		[JsonProperty("returnComment")]
		public string ReturnComment { get; set; }
	}
}
