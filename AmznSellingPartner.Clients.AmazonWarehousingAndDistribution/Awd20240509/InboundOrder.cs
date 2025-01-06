namespace AmznSellingPartner.Clients.AmazonWarehousingAndDistribution.Awd20240509
{
	using AmznSellingPartner.Clients.Attributes;
	using AmznSellingPartner.Clients.Values;

	using Newtonsoft.Json;

	using System.Collections.Generic;

	/// <summary>
	/// Represents an AWD inbound order.
	/// </summary>
	public class InboundOrder : BaseClass
	{
		/// <summary>
		/// List of inbound shipments part of this order.
		/// </summary>
		[JsonProperty("channelPlacedInboundShipments")]
		[IsRequired]
		[MinItems(1)]
		public List<InboundShipment> ChannelPlacedInboundShipments { get; set; } 

		/// <summary>
		/// Date when this order was created.
		/// </summary>
		[JsonProperty("createdAt")]
		[IsRequired]
		public DateTimeValue CreatedAt { get; set; } 

		/// <summary>
		/// Reference ID that can be used to correlate the order with partner resources.
		/// </summary>
		[JsonProperty("externalReferenceId")]
		public string ExternalReferenceId { get; set; } 

		/// <summary>
		/// Inbound order ID.
		/// </summary>
		[JsonProperty("orderId")]
		[IsRequired]
		public string OrderId { get; set; } 

		/// <summary>
		/// Inbound order status.
		/// </summary>
		[JsonProperty("orderStatus")]
		[IsRequired]
		public InboundStatus OrderStatus { get; set; } 

		/// <summary>
		/// Inbound order version.
		/// </summary>
		[JsonProperty("orderVersion")]
		[IsRequired]
		public string OrderVersion { get; set; } 

		/// <summary>
		/// Origin address from where the inbound order will be shipped.
		/// </summary>
		[JsonProperty("originAddress")]
		[IsRequired]
		public Address OriginAddress { get; set; } 

		/// <summary>
		/// List of packages to be inbounded.
		/// </summary>
		[JsonProperty("packagesToInbound")]
		[IsRequired]
		[MinItems(1)]
		public List<DistributionPackageQuantity> PackagesToInbound { get; set; } 

		[JsonProperty("preferences")]
		public InboundPreferences Preferences { get; set; } 

		/// <summary>
		/// Date by which this order will be shipped.
		/// </summary>
		[JsonProperty("shipBy")]
		public DateTimeValue ShipBy { get; set; } 

		/// <summary>
		/// Date when this order was last updated.
		/// </summary>
		[JsonProperty("updatedAt")]
		public DateTimeValue UpdatedAt { get; set; } 
	}
}
