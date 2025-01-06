namespace AmznSellingPartner.Clients.AmazonWarehousingAndDistribution.Awd20240509
{
	using AmznSellingPartner.Clients.Attributes;
	using AmznSellingPartner.Clients.Values;

	using Newtonsoft.Json;

	using System.Collections.Generic;

	/// <summary>
	/// Represents an AWD inbound shipment.
	/// </summary>
	public class InboundShipment : BaseClass
	{
		/// <summary>
		/// The shipment carrier code.
		/// </summary>
		[JsonProperty("carrierCode")]
		public CarrierCode CarrierCode { get; set; } 

		/// <summary>
		/// Timestamp when the shipment was created. The date is returned in <a href='https://developer-docs.amazon.com/sp-api/docs/iso-8601'>ISO
		/// 8601</a> format.
		/// </summary>
		[JsonProperty("createdAt")]
		public DateTimeValue CreatedAt { get; set; } 

		/// <summary>
		/// Destination address for this shipment.
		/// </summary>
		[JsonProperty("destinationAddress")]
		[IsRequired]
		public Address DestinationAddress { get; set; } 

		/// <summary>
		/// Client-provided reference ID that can correlate this shipment to client resources. For example, to map
		/// this shipment to an internal bookkeeping order record.
		/// </summary>
		[JsonProperty("externalReferenceId")]
		public string ExternalReferenceId { get; set; } 

		/// <summary>
		/// The AWD inbound order ID that this inbound shipment belongs to.
		/// </summary>
		[JsonProperty("orderId")]
		[IsRequired]
		[MinLength(1)]
		public string OrderId { get; set; } 

		/// <summary>
		/// Origin address for this shipment.
		/// </summary>
		[JsonProperty("originAddress")]
		[IsRequired]
		public Address OriginAddress { get; set; } 

		/// <summary>
		/// Quantity received (at the receiving end) as part of this shipment.
		/// </summary>
		[JsonProperty("receivedQuantity")]
		public List<InventoryQuantity> ReceivedQuantity { get; set; } 

		/// <summary>
		/// Timestamp when the shipment will be shipped.
		/// </summary>
		[JsonProperty("shipBy")]
		public DateTimeValue ShipBy { get; set; } 

		/// <summary>
		/// Packages that are part of this shipment.
		/// </summary>
		[JsonProperty("shipmentContainerQuantities")]
		[IsRequired]
		public List<DistributionPackageQuantity> ShipmentContainerQuantities { get; set; } 

		/// <summary>
		/// Unique shipment ID.
		/// </summary>
		[JsonProperty("shipmentId")]
		[IsRequired]
		[MinLength(1)]
		public string ShipmentId { get; set; } 

		/// <summary>
		/// Quantity details at SKU level for the shipment. This attribute will only appear if the skuQuantities
		/// parameter in the request is set to SHOW.
		/// </summary>
		[JsonProperty("shipmentSkuQuantities")]
		public List<SkuQuantity> ShipmentSkuQuantities { get; set; } 

		/// <summary>
		/// Assigned region where the order will be shipped. This can differ from what was passed as preference.
		/// AWD currently supports following region IDs: [us-west, us-east]
		/// </summary>
		[JsonProperty("destinationRegion")]
		public string DestinationRegion { get; set; } 

		/// <summary>
		/// Current status of this shipment.
		/// </summary>
		[JsonProperty("shipmentStatus")]
		[IsRequired]
		public InboundShipmentStatus ShipmentStatus { get; set; } 

		/// <summary>
		/// Carrier-unique tracking ID for this shipment.
		/// </summary>
		[JsonProperty("trackingId")]
		[MinLength(1)]
		public string TrackingId { get; set; } 

		/// <summary>
		/// Timestamp when the shipment was updated. The date is returned in <a href='https://developer-docs.amazon.com/sp-api/docs/iso-8601'>ISO
		/// 8601</a> format.
		/// </summary>
		[JsonProperty("updatedAt")]
		public DateTimeValue UpdatedAt { get; set; } 

		/// <summary>
		/// An AWD-provided reference ID that you can use to interact with the warehouse. For example, a carrier
		/// appointment booking.
		/// </summary>
		[JsonProperty("warehouseReferenceId")]
		public string WarehouseReferenceId { get; set; } 
	}
}
