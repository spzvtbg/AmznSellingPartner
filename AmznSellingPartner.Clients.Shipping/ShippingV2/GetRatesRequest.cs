namespace AmznSellingPartner.Clients.Shipping.ShippingV2
{
	using AmznSellingPartner.Clients.Attributes;

	using Newtonsoft.Json;

	using System;

	/// <summary>
	/// The request schema for the getRates operation. When the channelType is Amazon, the shipTo address is
	/// not required and will be ignored.
	/// </summary>
	public class GetRatesRequest : BaseClass
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

		/// <summary>
		/// This field describe shipper instruction.
		/// </summary>
		[JsonProperty("shipperInstruction")]
		public ShipperInstruction ShipperInstruction { get; set; }

		[IsRequired]
		[JsonProperty("packages")]
		public PackageList Packages { get; set; }

		[JsonProperty("valueAddedServices")]
		public ValueAddedServiceDetails ValueAddedServices { get; set; }

		[JsonProperty("taxDetails")]
		public TaxDetailList TaxDetails { get; set; }

		[IsRequired]
		[JsonProperty("channelDetails")]
		public ChannelDetails ChannelDetails { get; set; }

		[JsonProperty("clientReferenceDetails")]
		public ClientReferenceDetails ClientReferenceDetails { get; set; }

		[JsonProperty("shipmentType")]
		public ShipmentType ShipmentType { get; set; }

		[JsonProperty("destinationAccessPointDetails")]
		public AccessPointDetails DestinationAccessPointDetails { get; set; }
	}
}
