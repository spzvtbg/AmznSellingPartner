namespace AmznSellingPartner.Clients.AmazonWarehousingAndDistribution.Awd20240509
{
	using AmznSellingPartner.Clients.Attributes;

	using Newtonsoft.Json;

	using System;
	using System.Collections.Generic;

	/// <summary>
	/// Represents an AWD outbound shipment
	/// </summary>
	public class OutboundShipment : BaseClass
	{
		/// <summary>
		/// Timestamp when the shipment was created
		/// </summary>
		[JsonProperty("createdAt")]
		public DateTime CreatedAt { get; set; }

		/// <summary>
		/// Destination address for this shipment
		/// </summary>
		[IsRequired]
		[JsonProperty("destinationAddress")]
		public Address DestinationAddress { get; set; }

		/// <summary>
		/// Outbound order ID this outbound shipment belongs to
		/// </summary>
		[IsRequired]
		[JsonProperty("orderId")]
		public string OrderId { get; set; }

		/// <summary>
		/// Origin address for this shipment
		/// </summary>
		[IsRequired]
		[JsonProperty("originAddress")]
		public Address OriginAddress { get; set; }

		/// <summary>
		/// Specific distribution packages that are included in the context of this shipment
		/// </summary>
		[JsonProperty("shipmentPackageQuantities")]
		public List<DistributionPackageQuantity> ShipmentPackageQuantities { get; set; }

		/// <summary>
		/// Unique shipment ID
		/// </summary>
		[IsRequired]
		[JsonProperty("shipmentId")]
		public string ShipmentId { get; set; }

		/// <summary>
		/// Specific product units that are included in the context of this shipment
		/// </summary>
		[JsonProperty("shipmentProductQuantities")]
		public List<ProductQuantity> ShipmentProductQuantities { get; set; }

		/// <summary>
		/// Current status of this shipment
		/// </summary>
		[IsRequired]
		[JsonProperty("shipmentStatus")]
		public OutboundShipmentStatus ShipmentStatus { get; set; }

		/// <summary>
		/// Timestamp when the shipment was updated
		/// </summary>
		[JsonProperty("updatedAt")]
		public DateTime UpdatedAt { get; set; }
	}
}
