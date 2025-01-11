namespace AmznSellingPartner.Clients.Shipping.ShippingV2
{
	using AmznSellingPartner.Clients.Attributes;

	using Newtonsoft.Json;

	/// <summary>
	/// The request schema for the directPurchaseShipment operation. When the channel type is Amazon,
	/// the shipTo address is not required and will be ignored.
	/// </summary>
	public class DirectPurchaseRequest : BaseClass
	{
		/// <summary>
		/// The address where the shipment will be delivered. For vendor orders, shipTo information is
		/// pulled directly from the Amazon order.
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

		[JsonProperty("channelDetails")]
		[IsRequired]
		public ChannelDetails ChannelDetails { get; set; } 

		/// <summary>
		/// The document (label) specifications requested. The default label returned is PNG DPI 203 4x6
		/// if no label specification is provided. Requesting an invalid file format results in a fail
		/// ure.
		/// </summary>
		[JsonProperty("labelSpecifications")]
		public RequestedDocumentSpecification LabelSpecifications { get; set; } 
	}
}
