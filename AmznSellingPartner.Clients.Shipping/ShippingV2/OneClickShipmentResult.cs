namespace AmznSellingPartner.Clients.Shipping.ShippingV2
{
	using AmznSellingPartner.Clients.Attributes;

	using Newtonsoft.Json;

	/// <summary>
	/// The payload for the OneClickShipment API.
	/// </summary>
	public class OneClickShipmentResult : BaseClass
	{
		[JsonProperty("shipmentId")]
		[IsRequired]
		public ShipmentId ShipmentId { get; set; } 

		[JsonProperty("packageDocumentDetails")]
		[IsRequired]
		public PackageDocumentDetailList PackageDocumentDetails { get; set; } 

		[JsonProperty("promise")]
		[IsRequired]
		public Promise Promise { get; set; } 

		[JsonProperty("carrier")]
		[IsRequired]
		public Carrier Carrier { get; set; } 

		[JsonProperty("service")]
		[IsRequired]
		public Service Service { get; set; } 

		[JsonProperty("totalCharge")]
		[IsRequired]
		public Currency TotalCharge { get; set; } 
	}
}
