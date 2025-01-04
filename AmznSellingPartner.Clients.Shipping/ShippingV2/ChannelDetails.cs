namespace AmznSellingPartner.Clients.Shipping.ShippingV2
{
	using AmznSellingPartner.Clients.Attributes;

	using Newtonsoft.Json;

	/// <summary>
	/// Shipment source channel related information.
	/// </summary>
	public class ChannelDetails : BaseClass
	{
		[JsonProperty("channelType")]
		[IsRequired]
		public ChannelType ChannelType { get; set; } 

		[JsonProperty("amazonOrderDetails")]
		public AmazonOrderDetails AmazonOrderDetails { get; set; } 

		[JsonProperty("amazonShipmentDetails")]
		public AmazonShipmentDetails AmazonShipmentDetails { get; set; } 
	}
}
