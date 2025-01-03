namespace AmznSellingPartner.Clients.Shipping.ShippingV2
{
	using AmznSellingPartner.Clients.Attributes;

	using Newtonsoft.Json;

	/// <summary>
	/// Shipment source channel related information.
	/// </summary>
	public class ChannelDetails : BaseClass
	{
		[IsRequired]
		[JsonProperty("channelType")]
		public ChannelType ChannelType { get; set; }

		[JsonProperty("amazonOrderDetails")]
		public AmazonOrderDetails AmazonOrderDetails { get; set; }

		[JsonProperty("amazonShipmentDetails")]
		public AmazonShipmentDetails AmazonShipmentDetails { get; set; }
	}
}
