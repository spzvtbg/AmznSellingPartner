namespace AmznSellingPartner.Clients.FulfillmentOutbound.FulfillmentOutbound20200701
{
	using AmznSellingPartner.Clients.Attributes;

	using Newtonsoft.Json;

	/// <summary>
	/// An item that Amazon accepted for return.
	/// </summary>
	public class ReturnItem : BaseClass
	{
		/// <summary>
		/// An identifier assigned by the seller to the return item.
		/// </summary>
		[IsRequired]
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
		[JsonProperty("sellerReturnReasonCode")]
		public string SellerReturnReasonCode { get; set; }

		/// <summary>
		/// An optional comment about the return item.
		/// </summary>
		[JsonProperty("returnComment")]
		public string ReturnComment { get; set; }

		/// <summary>
		/// The return reason code that the Amazon fulfillment center assigned to the return item.
		/// </summary>
		[JsonProperty("amazonReturnReasonCode")]
		public string AmazonReturnReasonCode { get; set; }

		/// <summary>
		/// Indicates if the return item has been processed by an Amazon fulfillment center.
		/// </summary>
		[IsRequired]
		[JsonProperty("status")]
		public FulfillmentReturnItemStatus Status { get; set; }

		/// <summary>
		/// Indicates when the status last changed.
		/// </summary>
		[IsRequired]
		[JsonProperty("statusChangedDate")]
		public Timestamp StatusChangedDate { get; set; }

		/// <summary>
		/// Identifies the return authorization used to return this item. Refer to `ReturnAuthorization`.
		/// </summary>
		[JsonProperty("returnAuthorizationId")]
		public string ReturnAuthorizationId { get; set; }

		[JsonProperty("returnReceivedCondition")]
		public ReturnItemDisposition ReturnReceivedCondition { get; set; }

		/// <summary>
		/// The identifier for the Amazon fulfillment center that processed the return item.
		/// </summary>
		[JsonProperty("fulfillmentCenterId")]
		public string FulfillmentCenterId { get; set; }
	}
}
