namespace AmznSellingPartner.Clients.AmazonWarehousingAndDistribution.Awd20240509
{
	using AmznSellingPartner.Clients.Attributes;

	using Newtonsoft.Json;

	using System;
	using System.Collections.Generic;

	/// <summary>
	/// Represents an AWD inbound order.
	/// </summary>
	public class InboundOrder : BaseClass
	{
		/// <summary>
		/// List of inbound shipments part of this order.
		/// </summary>
		[IsRequired]
		[MinItems(1)]
		[JsonProperty("channelPlacedInboundShipments")]
		public List<InboundShipment> ChannelPlacedInboundShipments { get; set; }

		/// <summary>
		/// Date when this order was created.
		/// </summary>
		[IsRequired]
		[JsonProperty("createdAt")]
		public DateTime CreatedAt { get; set; }

		/// <summary>
		/// Reference ID that can be used to correlate the order with partner resources.
		/// </summary>
		[JsonProperty("externalReferenceId")]
		public string ExternalReferenceId { get; set; }

		/// <summary>
		/// Inbound order ID.
		/// </summary>
		[IsRequired]
		[JsonProperty("orderId")]
		public string OrderId { get; set; }

		/// <summary>
		/// Inbound order status.
		/// </summary>
		[IsRequired]
		[JsonProperty("orderStatus")]
		public InboundStatus OrderStatus { get; set; }

		/// <summary>
		/// Inbound order version.
		/// </summary>
		[IsRequired]
		[JsonProperty("orderVersion")]
		public string OrderVersion { get; set; }

		/// <summary>
		/// Origin address from where the inbound order will be shipped.
		/// </summary>
		[IsRequired]
		[JsonProperty("originAddress")]
		public Address OriginAddress { get; set; }

		/// <summary>
		/// List of packages to be inbounded.
		/// </summary>
		[IsRequired]
		[MinItems(1)]
		[JsonProperty("packagesToInbound")]
		public List<DistributionPackageQuantity> PackagesToInbound { get; set; }

		[JsonProperty("preferences")]
		public InboundPreferences Preferences { get; set; }

		/// <summary>
		/// Date by which this order will be shipped.
		/// </summary>
		[JsonProperty("shipBy")]
		public DateTime ShipBy { get; set; }

		/// <summary>
		/// Date when this order was last updated.
		/// </summary>
		[JsonProperty("updatedAt")]
		public DateTime UpdatedAt { get; set; }
	}
}
