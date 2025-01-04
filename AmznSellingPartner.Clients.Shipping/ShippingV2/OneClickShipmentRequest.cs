namespace AmznSellingPartner.Clients.Shipping.ShippingV2
{
	using AmznSellingPartner.Clients.Attributes;

	using Newtonsoft.Json;

	using System;

	/// <summary>
	/// The request schema for the OneClickShipment operation. When the channelType is not Amazon, shipTo is
	/// required and when channelType is Amazon shipTo is ignored.
	/// </summary>
	public class OneClickShipmentRequest : BaseClass
	{
		/// <summary>
		/// The ship to address.
		/// </summary>
		[JsonProperty("shipTo")]
		public Address ShipTo { get; set; }

		/// <summary>
		/// The ship from address.
		/// </summary>
		[JsonProperty("shipFrom")]
		[IsRequired]
		public Address ShipFrom { get; set; }

		/// <summary>
		/// The return to address.
		/// </summary>
		[JsonProperty("returnTo")]
		public Address ReturnTo { get; set; }

		/// <summary>
		/// The ship date and time (the requested pickup). This defaults to the current date and time.
		/// </summary>
		[JsonProperty("shipDate")]
		public DateTime ShipDate { get; set; }

		[JsonProperty("packages")]
		[IsRequired]
		public PackageList Packages { get; set; }

		[JsonProperty("valueAddedServicesDetails")]
		public OneClickShipmentValueAddedServiceDetails ValueAddedServicesDetails { get; set; }

		[JsonProperty("taxDetails")]
		public TaxDetailList TaxDetails { get; set; }

		[JsonProperty("channelDetails")]
		[IsRequired]
		public ChannelDetails ChannelDetails { get; set; }

		[JsonProperty("labelSpecifications")]
		[IsRequired]
		public RequestedDocumentSpecification LabelSpecifications { get; set; }

		[JsonProperty("serviceSelection")]
		[IsRequired]
		public ServiceSelection ServiceSelection { get; set; }

		/// <summary>
		/// Optional field for shipper instruction.
		/// </summary>
		[JsonProperty("shipperInstruction")]
		public ShipperInstruction ShipperInstruction { get; set; }

		[JsonProperty("destinationAccessPointDetails")]
		public AccessPointDetails DestinationAccessPointDetails { get; set; }
	}
}
