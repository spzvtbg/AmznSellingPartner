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
		[IsRequired]
		[JsonProperty("shipFrom")]
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

		[IsRequired]
		[JsonProperty("packages")]
		public PackageList Packages { get; set; }

		[JsonProperty("valueAddedServicesDetails")]
		public OneClickShipmentValueAddedServiceDetails ValueAddedServicesDetails { get; set; }

		[JsonProperty("taxDetails")]
		public TaxDetailList TaxDetails { get; set; }

		[IsRequired]
		[JsonProperty("channelDetails")]
		public ChannelDetails ChannelDetails { get; set; }

		[IsRequired]
		[JsonProperty("labelSpecifications")]
		public RequestedDocumentSpecification LabelSpecifications { get; set; }

		[IsRequired]
		[JsonProperty("serviceSelection")]
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
