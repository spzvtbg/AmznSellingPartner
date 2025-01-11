namespace AmznSellingPartner.Clients.FulfillmentOutbound.FulfillmentOutbound20200701
{
	using AmznSellingPartner.Clients.Attributes;

	using Newtonsoft.Json;

	using System.Collections.Generic;

	/// <summary>
	/// Delivery and item information for a shipment in a fulfillment order.
	/// </summary>
	public class FulfillmentShipment : BaseClass
	{
		/// <summary>
		/// A shipment identifier assigned by Amazon.
		/// </summary>
		[JsonProperty("amazonShipmentId")]
		[IsRequired]
		public string AmazonShipmentId { get; set; } 

		/// <summary>
		/// An identifier for the fulfillment center that the shipment will be sent from.
		/// </summary>
		[JsonProperty("fulfillmentCenterId")]
		[IsRequired]
		public string FulfillmentCenterId { get; set; } 

		/// <summary>
		/// The current status of the shipment.
		/// </summary>
		[JsonProperty("fulfillmentShipmentStatus")]
		[IsRequired]
		public FulfillmentShipmentStatus FulfillmentShipmentStatus { get; set; } 

		/// <summary>
		/// The meaning of the `shippingDate` value depends on the current status of the shipment. If the
		/// current value of `FulfillmentShipmentStatus` is:  * Pending - `shippingDate` represents the
		/// estimated time that the shipment will leave the Amazon fulfillment center.  * Shipped - `shippingDate`
		/// represents the date that the shipment left the Amazon fulfillment center. If a shipment includes
		/// more than one package, `shippingDate` applies to all of the packages in the shipment. If the
		/// value of `FulfillmentShipmentStatus` is `CancelledByFulfiller` or `CancelledBySeller`, `shippingDate`
		/// is not returned. The value must be in <a href='https://developer-docs.amazon.com/sp-api/docs/iso-8601'>ISO
		/// 8601</a> format.
		/// </summary>
		[JsonProperty("shippingDate")]
		public Timestamp ShippingDate { get; set; } 

		/// <summary>
		/// The estimated arrival date and time of the shipment. Must be in <a href='https://developer-docs.amazon.com/sp-api/docs/iso-8601'>ISO
		/// 8601</a> format. Note that this value can change over time. If a shipment includes more than
		/// one package, `estimatedArrivalDate` applies to all of the packages in the shipment. If the
		/// shipment has been cancelled, `estimatedArrivalDate` is not returned.
		/// </summary>
		[JsonProperty("estimatedArrivalDate")]
		public Timestamp EstimatedArrivalDate { get; set; } 

		/// <summary>
		/// Provides additional insight into shipment timeline. Primairly used to communicate that actual
		/// delivery dates aren't available.
		/// </summary>
		[JsonProperty("shippingNotes")]
		public List<string> ShippingNotes { get; set; } 

		[JsonProperty("fulfillmentShipmentItem")]
		[IsRequired]
		public FulfillmentShipmentItemList FulfillmentShipmentItem { get; set; } 

		[JsonProperty("fulfillmentShipmentPackage")]
		public FulfillmentShipmentPackageList FulfillmentShipmentPackage { get; set; } 
	}
}
