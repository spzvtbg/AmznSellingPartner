namespace AmznSellingPartner.Clients.Shipping.ShippingV2
{
	using AmznSellingPartner.Clients.Attributes;

	using Newtonsoft.Json;

	/// <summary>
	/// The request schema for the directPurchaseShipment operation. When the channel type is Amazon, the shipTo addre
	/// s is not required and will be ignored.
	/// </summary>
	public class DirectPurchaseRequest : BaseClass
	{
		/// <summary>
		/// The address where the shipment will be delivered. For vendor orders, shipTo information is pulled directly fro
		/// the Amazon order.
		/// </summary>
		[JsonProperty("shipTo")]
		public Address ShipTo { get; set; }

		/// <summary>
		/// The address where the package will be picked up.
		/// </summary>
		[JsonProperty("shipFrom")]
		public Address ShipFrom { get; set; }

		/// <summary>
		/// The address where the package will be returned if it cannot be delivered.
		/// </summary>
		[JsonProperty("returnTo")]
		public Address ReturnTo { get; set; }

		[JsonProperty("packages")]
		public PackageList Packages { get; set; }

		[IsRequired]
		[JsonProperty("channelDetails")]
		public ChannelDetails ChannelDetails { get; set; }

		/// <summary>
		/// The document (label) specifications requested. The default label returned is PNG DPI 203 4x6 if no label speci
		/// ication is provided. Requesting an invalid file format results in a failure.
		/// </summary>
		[JsonProperty("labelSpecifications")]
		public RequestedDocumentSpecification LabelSpecifications { get; set; }
	}
}
